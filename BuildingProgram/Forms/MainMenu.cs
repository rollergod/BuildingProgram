using BuildingProgram.Context;
using BuildingProgram.Models;
using Microsoft.EntityFrameworkCore;
using System.Data;
using Test;

namespace BuildingProgram.Forms
{
    public partial class MainMenu : BaseForm
    {
        private AppDbContext _context;
        private int _objNum = 0;
        private int _userId; 
        bool siderbarExpand = false;
        bool reportCollapse = true;
        public MainMenu(int userId = 0)
        {
            InitializeComponent();
            _userId = userId;
            _context = new AppDbContext();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            var buildingObjects = _context.BuildingObjects
                .Include(x => x.Land)
                .Where(x => x.UserId == _userId)
                .ToList();

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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //objNum
            _objNum = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);

            if (_objNum > 0)
            {
                btn_ChangeBtn.Enabled = true;
                btn_AboutObject.Enabled = true;
            }
        }

        private List<BuildingObject> SearchData(string searchText)
        {
            int objectNumber;
            bool isNumber = int.TryParse(searchText, out objectNumber);

            return _context.BuildingObjects.Include(x => x.Land)
                .Where(x => isNumber ? x.ObjectNumber.ToString().Contains(searchText) : x.Land.Address.Contains(searchText))
                .ToList();
        }

        private void cb_IsBuildingEnded_CheckedChanged(object sender, EventArgs e)
        {
           if (cb_IsCheckedObject.Checked && cb_IsBuildingEnded.Checked && string.IsNullOrEmpty(tb_Search.Text))
            {
                var searchedObjects = _context.BuildingObjects
                    .Include(x => x.Land)
                    .Select(x => new
                    {
                        x.ObjectNumber,
                        x.Land.Address,
                        isChecked = x.IsChecked ? "Да" : "Нет",
                        isEnded = x.IsBuildingEnded ? "Да" : "Нет",
                    }).ToList();

                searchedObjects = searchedObjects.Where(x => x.isEnded == "Да" && x.isChecked == "Да").ToList();

                dataGridView1.DataSource = searchedObjects;
            }
            else if (!cb_IsCheckedObject.Checked && cb_OnlyOne.Checked && cb_IsBuildingEnded.Checked && string.IsNullOrEmpty(tb_Search.Text))
            {
                var data = _context.BuildingObjects
                .Include(x => x.Land)
                .ToList();

                dataGridView1.DataSource = data
                    .Where(x => x.UserId == _userId && x.IsBuildingEnded)
                    .Select(x => new
                    {
                        x.ObjectNumber,
                        x.Land.Address,
                        isChecked = x.IsChecked ? "Да" : "Нет",
                        isEnded = x.IsBuildingEnded ? "Да" : "Нет",
                    }).ToList();
            }
            else if(cb_IsBuildingEnded.Checked && string.IsNullOrEmpty(tb_Search.Text))
            {
                var searchedObjects = _context.BuildingObjects
                    .Include(x => x.Land)
                    .Select(x => new
                    {
                        x.ObjectNumber,
                        x.Land.Address,
                        isChecked = x.IsChecked ? "Да" : "Нет",
                        isEnded = x.IsBuildingEnded ? "Да" : "Нет",
                    }).ToList();

                searchedObjects = searchedObjects.Where(x => x.isEnded == "Да").ToList();

                dataGridView1.DataSource = searchedObjects;
            }
            
            else if (cb_IsCheckedObject.Checked && !cb_IsBuildingEnded.Checked && string.IsNullOrEmpty(tb_Search.Text))
            {
                var searchedObjects = _context.BuildingObjects
                    .Include(x => x.Land)
                    .Select(x => new
                    {
                        x.ObjectNumber,
                        x.Land.Address,
                        isChecked = x.IsChecked ? "Да" : "Нет",
                        isEnded = x.IsBuildingEnded ? "Да" : "Нет",
                    }).ToList();

                searchedObjects = searchedObjects.Where(x => x.isChecked == "Да").ToList();

                dataGridView1.DataSource = searchedObjects;
            }
            else if (cb_OnlyOne.Checked && !cb_IsBuildingEnded.Checked && !cb_IsCheckedObject.Checked && string.IsNullOrEmpty(tb_Search.Text))
            {
                var data = _context.BuildingObjects
               .Include(x => x.Land)
               .ToList();

                dataGridView1.DataSource = data
                    .Where(x => x.UserId == _userId)
                    .Select(x => new
                    {
                        x.ObjectNumber,
                        x.Land.Address,
                        isChecked = x.IsChecked ? "Да" : "Нет",
                        isEnded = x.IsBuildingEnded ? "Да" : "Нет",
                    }).ToList();
            }
            else if (cb_OnlyOne.Checked && cb_IsBuildingEnded.Checked && !cb_IsCheckedObject.Checked && !string.IsNullOrEmpty(tb_Search.Text))
            {
                string searchText = tb_Search.Text;

                var searchedData =
                    SearchData(searchText)
                    .Where(x => x.UserId == _userId)
                    .Select(x => new
                    {
                        x.ObjectNumber,
                        x.Land.Address,
                        isChecked = x.IsChecked ? "Да" : "Нет",
                        isEnded = x.IsBuildingEnded ? "Да" : "Нет",
                    })
                    .ToList();

                dataGridView1.DataSource = searchedData;
            }
            else if (!string.IsNullOrEmpty(tb_Search.Text) && !cb_OnlyOne.Checked && cb_IsCheckedObject.Checked && cb_IsBuildingEnded.Checked)
            {
                string searchText = tb_Search.Text;

                var searchedData =
                    SearchData(searchText)
                    .Where(x => x.IsBuildingEnded && x.IsChecked)
                    .Select(x => new
                    {
                        x.ObjectNumber,
                        x.Land.Address,
                        isChecked = x.IsChecked ? "Да" : "Нет",
                        isEnded = x.IsBuildingEnded ? "Да" : "Нет",
                    })
                    .ToList();

                dataGridView1.DataSource = searchedData;
            }
            else if (cb_OnlyOne.Checked && !cb_IsBuildingEnded.Checked && !cb_IsCheckedObject.Checked && !string.IsNullOrEmpty(tb_Search.Text))
            {
                string searchText = tb_Search.Text;

                var searchedData =
                    SearchData(searchText)
                    .Where(x => x.UserId == _userId)
                    .Select(x => new
                    {
                        x.ObjectNumber,
                        x.Land.Address,
                        isChecked = x.IsChecked ? "Да" : "Нет",
                        isEnded = x.IsBuildingEnded ? "Да" : "Нет",
                    })
                    .ToList();

                dataGridView1.DataSource = searchedData;
            }
            else if (cb_IsCheckedObject.Checked && !cb_IsBuildingEnded.Checked && !string.IsNullOrEmpty(tb_Search.Text))
            {
                string searchText = tb_Search.Text;
                var searchedObjects = SearchData(searchText)
                     .Select(x => new
                     {
                         x.ObjectNumber,
                         x.Land.Address,
                         isChecked = x.IsChecked ? "Да" : "Нет",
                         isEnded = x.IsBuildingEnded ? "Да" : "Нет",
                     }).ToList();

                searchedObjects = searchedObjects.Where(x => x.isEnded == "Да").ToList();

                dataGridView1.DataSource = searchedObjects;
            }
            
            else if (!string.IsNullOrEmpty(tb_Search.Text) && !cb_OnlyOne.Checked && !cb_IsCheckedObject.Checked && cb_IsBuildingEnded.Checked)
            {
                string searchText = tb_Search.Text;

                var searchedData =
                    SearchData(searchText)
                    .Where(x => x.IsBuildingEnded)
                    .Select(x => new
                    {
                        x.ObjectNumber,
                        x.Land.Address,
                        isChecked = x.IsChecked ? "Да" : "Нет",
                        isEnded = x.IsBuildingEnded ? "Да" : "Нет",
                    })
                    .ToList();

                dataGridView1.DataSource = searchedData;
            }
            else if (!string.IsNullOrEmpty(tb_Search.Text) && !cb_OnlyOne.Checked && !cb_IsCheckedObject.Checked && !cb_IsBuildingEnded.Checked)
            {
                string searchText = tb_Search.Text;

                var searchedData =
                    SearchData(searchText)
                    .Select(x => new
                    {
                        x.ObjectNumber,
                        x.Land.Address,
                        isChecked = x.IsChecked ? "Да" : "Нет",
                        isEnded = x.IsBuildingEnded ? "Да" : "Нет",
                    })
                    .ToList();

                dataGridView1.DataSource = searchedData;
            }
            else
            {
                var data = _context.BuildingObjects.
                    Include(x => x.Land)
                    .Select(x => new
                    {
                        x.ObjectNumber,
                        x.Land.Address,
                        isChecked = x.IsChecked ? "Да" : "Нет",
                        isEnded = x.IsBuildingEnded ? "Да" : "Нет",
                    })
                    .ToList();

                dataGridView1.DataSource = data;
            }
        }

        private void cb_IsCheckedObject_CheckedChanged(object sender, EventArgs e)
        {
            if(cb_IsCheckedObject.Checked && cb_IsBuildingEnded.Checked && !string.IsNullOrEmpty(tb_Search.Text)) 
            {
                string searchText = tb_Search.Text;
                var searchedObjects = SearchData(searchText)
                    .Select(x => new
                    {
                        x.ObjectNumber,
                        x.Land.Address,
                        isChecked = x.IsChecked ? "Да" : "Нет",
                        isEnded = x.IsBuildingEnded ? "Да" : "Нет",
                    }).ToList();

                searchedObjects = searchedObjects.Where(x => x.isEnded == "Да" && x.isChecked == "Да").ToList();

                dataGridView1.DataSource = searchedObjects;
            }
            else if (cb_IsCheckedObject.Checked && cb_OnlyOne.Checked && !cb_IsBuildingEnded.Checked && string.IsNullOrEmpty(tb_Search.Text))
            {
                var data = _context.BuildingObjects
                .Include(x => x.Land)
                .ToList();

                dataGridView1.DataSource = data
                    .Where(x => x.UserId == _userId && x.IsChecked)
                    .Select(x => new
                    {
                        x.ObjectNumber,
                        x.Land.Address,
                        isChecked = x.IsChecked ? "Да" : "Нет",
                        isEnded = x.IsBuildingEnded ? "Да" : "Нет",
                    }).ToList();
            }
            else if (cb_IsCheckedObject.Checked && cb_IsBuildingEnded.Checked && string.IsNullOrEmpty(tb_Search.Text))
            {
                string searchText = tb_Search.Text;
                var searchedObjects = _context.BuildingObjects
                    .Include(x => x.Land)
                    .Select(x => new
                    {
                        x.ObjectNumber,
                        x.Land.Address,
                        isChecked = x.IsChecked ? "Да" : "Нет",
                        isEnded = x.IsBuildingEnded ? "Да" : "Нет",
                    }).ToList();

                searchedObjects = searchedObjects.Where(x => x.isEnded == "Да" && x.isChecked == "Да").ToList();

                dataGridView1.DataSource = searchedObjects;
            }
            else if (cb_IsCheckedObject.Checked && !cb_IsBuildingEnded.Checked && string.IsNullOrEmpty(tb_Search.Text))
            {
                string searchText = tb_Search.Text;
                var searchedObjects = _context.BuildingObjects
                    .Include(x => x.Land)
                    .Select(x => new
                    {
                        x.ObjectNumber,
                        x.Land.Address,
                        isChecked = x.IsChecked ? "Да" : "Нет",
                        isEnded = x.IsBuildingEnded ? "Да" : "Нет",
                    }).ToList();

                searchedObjects = searchedObjects.Where(x => x.isChecked == "Да").ToList();

                dataGridView1.DataSource = searchedObjects;
            }
            else if (!cb_IsCheckedObject.Checked && cb_IsBuildingEnded.Checked && string.IsNullOrEmpty(tb_Search.Text))
            {
                var searchedObjects = _context.BuildingObjects
                    .Include(x => x.Land)
                    .Select(x => new
                    {
                        x.ObjectNumber,
                        x.Land.Address,
                        isChecked = x.IsChecked ? "Да" : "Нет",
                        isEnded = x.IsBuildingEnded ? "Да" : "Нет",
                    }).ToList();

                searchedObjects = searchedObjects.Where(x => x.isEnded == "Да").ToList();

                dataGridView1.DataSource = searchedObjects;
            }
            else if (!cb_IsCheckedObject.Checked && cb_IsBuildingEnded.Checked && !string.IsNullOrEmpty(tb_Search.Text))
            {
                string searchText = tb_Search.Text;
                var searchedObjects = SearchData(searchText)
                     .Select(x => new
                     {
                         x.ObjectNumber,
                         x.Land.Address,
                         isChecked = x.IsChecked ? "Да" : "Нет",
                         isEnded = x.IsBuildingEnded ? "Да" : "Нет",
                     }).ToList();

                searchedObjects = searchedObjects.Where(x => x.isEnded == "Да").ToList();

                dataGridView1.DataSource = searchedObjects;
            }
            else if(cb_OnlyOne.Checked && !cb_IsBuildingEnded.Checked && !cb_IsCheckedObject.Checked && string.IsNullOrEmpty(tb_Search.Text))
            {
                var data = _context.BuildingObjects
               .Include(x => x.Land)
               .ToList();

                dataGridView1.DataSource = data
                    .Where(x => x.UserId == _userId)
                    .Select(x => new
                    {
                        x.ObjectNumber,
                        x.Land.Address,
                        isChecked = x.IsChecked ? "Да" : "Нет",
                        isEnded = x.IsBuildingEnded ? "Да" : "Нет",
                    }).ToList();
            }
            else if (cb_OnlyOne.Checked && !cb_IsBuildingEnded.Checked && cb_IsCheckedObject.Checked && !string.IsNullOrEmpty(tb_Search.Text))
            {
                string searchText = tb_Search.Text;

                var searchedData = 
                    SearchData(searchText)
                    .Where(x => x.UserId == _userId && x.IsChecked)
                    .Select(x => new
                    {
                        x.ObjectNumber,
                        x.Land.Address,
                        isChecked = x.IsChecked ? "Да" : "Нет",
                        isEnded = x.IsBuildingEnded ? "Да" : "Нет",
                    })
                    .ToList();

                dataGridView1.DataSource = searchedData;
            }
            else if (cb_OnlyOne.Checked && !cb_IsBuildingEnded.Checked && !cb_IsCheckedObject.Checked && !string.IsNullOrEmpty(tb_Search.Text))
            {
                string searchText = tb_Search.Text;

                var searchedData =
                    SearchData(searchText)
                    .Where(x => x.UserId == _userId)
                    .Select(x => new
                    {
                        x.ObjectNumber,
                        x.Land.Address,
                        isChecked = x.IsChecked ? "Да" : "Нет",
                        isEnded = x.IsBuildingEnded ? "Да" : "Нет",
                    })
                    .ToList();

                dataGridView1.DataSource = searchedData;
            }
            else if (!string.IsNullOrEmpty(tb_Search.Text) && !cb_OnlyOne.Checked && cb_IsCheckedObject.Checked && !cb_IsBuildingEnded.Checked)
            {
                string searchText = tb_Search.Text;

                var searchedData =
                    SearchData(searchText)
                    .Where(x => x.IsChecked)
                    .Select(x => new
                    {
                        x.ObjectNumber,
                        x.Land.Address,
                        isChecked = x.IsChecked ? "Да" : "Нет",
                        isEnded = x.IsBuildingEnded ? "Да" : "Нет",
                    })
                    .ToList();

                dataGridView1.DataSource = searchedData;
            }
            else if(!string.IsNullOrEmpty(tb_Search.Text) && !cb_OnlyOne.Checked && !cb_IsCheckedObject.Checked && !cb_IsBuildingEnded.Checked)
            {
                string searchText = tb_Search.Text;

                var searchedData =
                    SearchData(searchText)
                    .Select(x => new
                    {
                        x.ObjectNumber,
                        x.Land.Address,
                        isChecked = x.IsChecked ? "Да" : "Нет",
                        isEnded = x.IsBuildingEnded ? "Да" : "Нет",
                    })
                    .ToList();

                dataGridView1.DataSource = searchedData;
            }
            else
            {
                var data = _context.BuildingObjects.
                    Include(x => x.Land)
                    .Select(x => new
                    {
                        x.ObjectNumber,
                        x.Land.Address,
                        isChecked = x.IsChecked ? "Да" : "Нет",
                        isEnded = x.IsBuildingEnded ? "Да" : "Нет",
                    })
                    .ToList();

                dataGridView1.DataSource = data;
            }
        }

        private void cb_OnlyOne_CheckedChanged(object sender, EventArgs e)
        {
            var data = _context.BuildingObjects
                .Include(x => x.Land)
                .ToList();

            if (cb_OnlyOne.Checked)
            {
                if (!string.IsNullOrEmpty(tb_Search.Text))
                {
                    dataGridView1.DataSource = 
                    SearchData(tb_Search.Text)
                    .Where(x => x.UserId == _userId)
                    .Select(x => new
                    {
                        x.ObjectNumber,
                        x.Land.Address,
                        isChecked = x.IsChecked ? "Да" : "Нет",
                        isEnded = x.IsBuildingEnded ? "Да" : "Нет",
                    }).ToList();
                }
                else
                {
                    dataGridView1.DataSource = data
                    .Where(x => x.UserId == _userId)
                    .Select(x => new
                    {
                        x.ObjectNumber,
                        x.Land.Address,
                        isChecked = x.IsChecked ? "Да" : "Нет",
                        isEnded = x.IsBuildingEnded ? "Да" : "Нет",
                    }).ToList();
                }
            }
            else
            {
                if (!string.IsNullOrEmpty(tb_Search.Text))
                {
                    dataGridView1.DataSource =
                    SearchData(tb_Search.Text)
                    .Select(x => new
                    {
                        x.ObjectNumber,
                        x.Land.Address,
                        isChecked = x.IsChecked ? "Да" : "Нет",
                        isEnded = x.IsBuildingEnded ? "Да" : "Нет",
                    }).ToList();
                }
                else
                {
                    dataGridView1.DataSource = data.Select(x => new
                    {
                        x.ObjectNumber,
                        x.Land.Address,
                        isChecked = x.IsChecked ? "Да" : "Нет",
                        isEnded = x.IsBuildingEnded ? "Да" : "Нет",
                    }).ToList(); ;
                }
                
            }
        }

        private void sidebarTimer_Tick(object sender, EventArgs e)
        {
            if (siderbarExpand)
            {
                sideBar.Width -= 10;
                if (sideBar.Width == sideBar.MinimumSize.Width)
                {
                    siderbarExpand = false;
                    sidebarTimer.Stop();
                }
            }
            else
            {
                sideBar.Width += 10;
                if (sideBar.Width == sideBar.MaximumSize.Width)
                {
                    siderbarExpand = true;
                    sidebarTimer.Stop();
                }
            }
        }

        private void reportTimer_Tick(object sender, EventArgs e)
        {
            if (reportCollapse)
            {
                reportContainer.Height += 10;
                if (reportContainer.Height == reportContainer.MaximumSize.Height)
                {
                    reportCollapse = false;
                    reportTimer.Stop();
                }
            }
            else
            {
                reportContainer.Height -= 10;
                if (reportContainer.Height == reportContainer.MinimumSize.Height)
                {
                    reportCollapse = true;
                    reportTimer.Stop();
                }
            }
        }

        private void menuPicture_Click(object sender, EventArgs e)
        {
            sidebarTimer.Start();
        }

        private void btn_ReportForm_Click(object sender, EventArgs e)
        {
            reportTimer.Start();
        }

        private void btn_ObjectForm_Click(object sender, EventArgs e)
        {
            // Main Menu
        }

        private void btn_OrgForm_Click(object sender, EventArgs e)
        {
            OrganizationForm orgForm = new OrganizationForm();
            orgForm.ShowDialog();
        }

        private void btn_LandForm_Click(object sender, EventArgs e)
        {
            LandForm landForm = new LandForm();
            landForm.ShowDialog();
        }

        private void btn_BuildingCompanyForm_Click(object sender, EventArgs e)
        {
            BuildingCompanyForm buildingCompanyForm = new BuildingCompanyForm();
            buildingCompanyForm.ShowDialog();
        }

        private void btn_RepForm_Click(object sender, EventArgs e)
        {
            ReportForm repForm = new ReportForm();
            repForm.ShowDialog();
        }

        private void btn_BuildingCompanyRep_Click(object sender, EventArgs e)
        {
            BuildingCompanyReportForm buildingCompanyReportForm = new BuildingCompanyReportForm();
            buildingCompanyReportForm.ShowDialog();
        }

        private void btn_AddObject_Click(object sender, EventArgs e)
        {
            AddNewObject addObjForm = new AddNewObject(_userId);
            addObjForm.ShowDialog();
        }

        private void btn_ChangeBtn_Click(object sender, EventArgs e)
        {
            var buildingObjectForChange = _context.BuildingObjects
                .FirstOrDefault(x => x.ObjectNumber == _objNum);

            if (_userId == buildingObjectForChange.UserId)
            {
                AddNewObject addLandForm = new AddNewObject(_userId, _objNum);
                addLandForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("У вас нет прав для редактирования данного объекта.");
            }
        }

        private void btn_AboutObject_Click(object sender, EventArgs e)
        {
            ObjectForm objForm = new ObjectForm(_objNum, _userId);
            objForm.ShowDialog();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            string searchText = tb_Search.Text;

            if (string.IsNullOrEmpty(searchText))
            {
                if (cb_OnlyOne.Checked)
                {
                    var data = _context.BuildingObjects
                    .Include(x => x.Land)
                    .Where(x => x.UserId == _userId)
                    .Select(x => new
                    {
                        x.ObjectNumber,
                        x.Land.Address,
                        isChecked = x.IsChecked ? "Да" : "Нет",
                        isEnded = x.IsBuildingEnded ? "Да" : "Нет",
                    });
                    dataGridView1.DataSource = data.ToList();
                }
                else
                {
                    var data = _context.BuildingObjects
                   .Include(x => x.Land)
                   .Select(x => new
                   {
                       x.ObjectNumber,
                       x.Land.Address,
                       isChecked = x.IsChecked ? "Да" : "Нет",
                       isEnded = x.IsBuildingEnded ? "Да" : "Нет",
                   });
                    dataGridView1.DataSource = data.ToList();
                }
            }
            else
            {
                if (cb_OnlyOne.Checked)
                {
                    var searchedObjects = SearchData(searchText)
                                        .Where(x => x.UserId == _userId)
                                       .Select(x => new
                                       {
                                           x.ObjectNumber,
                                           x.Land.Address,
                                           isChecked = x.IsChecked ? "Да" : "Нет",
                                           isEnded = x.IsBuildingEnded ? "Да" : "Нет",
                                       }).ToList();

                    dataGridView1.DataSource = searchedObjects;
                }
                else
                {
                    var searchedObjects = SearchData(searchText)
                                       .Select(x => new
                                       {
                                           x.ObjectNumber,
                                           x.Land.Address,
                                           isChecked = x.IsChecked ? "Да" : "Нет",
                                           isEnded = x.IsBuildingEnded ? "Да" : "Нет",
                                       }).ToList();

                    dataGridView1.DataSource = searchedObjects;
                }
            }
        }
    }
}
