﻿using BuildingProgram.Context;
using BuildingProgram.Tools;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BuildingProgram.Forms
{
    public partial class MainMenu : BaseForm
    {
        private AppDbContext _context;
        public MainMenu()
        {
            InitializeComponent();
            menuStrip1.Renderer = new NoHighlightRenderer();

            _context = new AppDbContext();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            var buildingObjects = _context.BuildingObjects.Include(x => x.Land).ToList();

            var data = buildingObjects.Select(x => new
            {
                x.ObjectNumber,
                x.Land.Address,
                isChecked = x.IsChecked ? "Да" : "Нет",
                isEnded = x.IsBuildingEnded ? "Да" : "Нет",
            }).ToList();

            dataGridView1.DataSource = data;
            
            dataGridView1.Columns[0].HeaderText = "Номер объекта";
            dataGridView1.Columns[1].HeaderText = "Адрес";
            dataGridView1.Columns[2].HeaderText = "Проверен ли объект";
            dataGridView1.Columns[3].HeaderText = "Закончена ли стройка";

            dataGridView1.Columns[1].Width= 275;
        }

        private void btn_AddObject_Click(object sender, EventArgs e)
        {
            AddNewObject addObjForm = new AddNewObject();
            addObjForm.ShowDialog();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            OrganizationForm orgForm = new OrganizationForm();
            orgForm.ShowDialog();
        }

        private void земельныеУчасткиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LandForm landForm = new LandForm();
            landForm.ShowDialog();
        }
    }
}
