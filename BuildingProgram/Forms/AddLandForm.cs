﻿using BuildingProgram.Context;
using BuildingProgram.Models;
using BuildingProgram.Tools;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace BuildingProgram.Forms
{
    public partial class AddLandForm : BaseForm
    {
        private AppDbContext _context;
        private int _landId;
        public AddLandForm(int landId = 0)
        {
            InitializeComponent();
            menuStrip1.Renderer = new NoHighlightRenderer();
            _context = new AppDbContext();
            _landId = landId;
        }

        private void AddLandForm_Load(object sender, EventArgs e)
        {
            var organizationNames = _context.Organizations
                .Select(x => x.OrganizationName)
                .ToList();

            cb_SellerId.DataSource = organizationNames;
            cb_Buyer.DataSource = organizationNames;

            if (_landId > 0)
            {
                this.Text = "Изменение земельного участка";

                var land = _context.Lands.Include(x => x.Seller).Include(x => x.Buyer).FirstOrDefault(x => x.Id == _landId);

                tb_CadastralNum.Texts = land.CadastralNumber;
                tb_Address.Texts = land.Address;
                tb_BuyPrice.Texts = land.BuyPrice.ToString();
                tb_SellPrice.Texts = land.SellPrice.ToString();
                cb_IsSold.Checked = land.IsSold;
                tb_Square.Texts = land.Square.ToString();

                cb_SellerId.Text = land.Seller.OrganizationName;
                cb_LandType.SelectedIndex = land.LandType.Value;

                if (land.LandType.HasValue) 
                    cb_LandType.SelectedIndex = land.LandType.Value;

                if (land.Buyer != null)
                    cb_Buyer.Text = land.Buyer.OrganizationName;

                btn_AddLand.Text = "Сохранить изменения";
            }
        }

        private void btn_AddLand_Click(object sender, EventArgs e)
        {
            // TODO : добавить валидацию 
            string cadastral = tb_CadastralNum.Texts;
            string address = tb_Address.Texts;
            decimal buyPrice = Convert.ToDecimal(tb_BuyPrice.Texts);
            decimal sellPrice = Convert.ToDecimal(tb_SellPrice.Texts);
            double square = Convert.ToDouble(tb_Square.Texts);
            string sellOrgName = cb_SellerId.SelectedValue.ToString();
            int landType = cb_LandType.SelectedIndex;
            bool isSold = cb_IsSold.Checked;

            string buyOrgName;
            Organization buyOrganization = new Organization();
            if (isSold)
            {
                buyOrgName = cb_Buyer.SelectedValue.ToString();
                buyOrganization = _context.Organizations.FirstOrDefault(x => x.OrganizationName == buyOrgName);
            }

            var sellOrganization = _context.Organizations.FirstOrDefault(x => x.OrganizationName == sellOrgName);

            if(_landId == 0)
            {
                Land landForAdd = new Land
                {
                    CadastralNumber = cadastral,
                    Address = address,
                    BuyPrice = buyPrice,
                    SellPrice = sellPrice,
                    IsSold = isSold,
                    SellerId = sellOrganization.Id,
                    LandType = landType,
                    Square = square,
                    BuyerId = isSold ? buyOrganization.Id : null,
                };

                _context.Lands.Add(landForAdd);
            }
            else
            {
                var landForChange = _context.Lands.FirstOrDefault(x => x.Id == _landId);

                landForChange.Address = address;
                landForChange.CadastralNumber= cadastral;
                landForChange.BuyPrice = buyPrice;
                landForChange.SellPrice = sellPrice;
                landForChange.IsSold = isSold;
                landForChange.LandType = landType;
                landForChange.Square = square;
                landForChange.SellerId = sellOrganization.Id;
                landForChange.BuyerId = isSold ? buyOrganization.Id : null;

                _context.Lands.Update(landForChange);
            }
            _context.SaveChanges();
            MessageBox.Show(_landId == 0 ? $"Земельный участок с кадастровым номером - {cadastral} был добавлен в список." :
                $"Земельный участок с кадастровым номером - {cadastral} был добавлен в список.");
        }

        private void cb_IsSold_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_IsSold.Checked)
            {
                label2.Visible = true;
                cb_Buyer.Visible = true;
            }
            else
            {
                label2.Visible = false;
                cb_Buyer.Visible = false;
            }
        }

        private void xToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
