﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Projekt.Forms;
using Projekt.Models;
using Projekt.Presenters;


namespace Projekt.Forms
{
    public partial class MainForm : Form, IViewChanger
    {
        UserControl control;
        ModelContainer session = new ModelContainer();
        public MainForm()
        {
            InitializeComponent();            
        }

        private void ShowControl(UserControl control)
        {
            Controls.Remove(this.control);
            this.control = control;
            Controls.Add(control);
        }

        public void ShowLogin()
        {
            var view = new LoginView(this);
            var model = new LoginModel(session); //sesja z userem
            var presenter = new LoginPresenter(model, view); 
            
            ShowControl(view);
            centerActualView();
        }

        public void ShowAdminMain()
        {
            var view = new AdminMainView(this);
            var model = new AdminMainModel(session);
            var presenter = new AdminMainPresenter(model, view);

            ShowControl(view);           

        }

        public void ShowNewOrder()
        {
            var view = new NewOrder(this);
            var model = new NewOrderModel(session);
            var presenter = new NewOrderPresenter(model, view);

            ShowControl(view);

        }

        public void ShowNewDriver()
        {
            var view = new NewDriver(this);
            var model = new NewDriverModel(session);
            var presenter = new NewDriverPresenter(model, view);

            ShowControl(view);
        }

        public void ShowNewVehicle()
        {
            var view = new NewVehicle(this);
            var model = new NewVehicleModel(session);
            var presenter = new NewVehiclePresenter(model, view);

            ShowControl(view);
        }

        public void ShowSettings()
        {
            var view = new Settings(this);
            var model = new SettingsModel(session);
            var presenter = new SettingsPresenter(model, view);

            ShowControl(view);
        }

        public void ShowEditDriver()
        {
            var view = new EditDriver(this);
            var model = new EditDriverModel(session);
            var presenter = new EditDriverPresenter(model, view);

            ShowControl(view);
        }

        public void ShowEditVehicle()
        {
            var view = new EditVehicle(this);
            var model = new EditVehicleModel(session);
            var presenter = new EditVehiclePresenter(model, view);

            ShowControl(view);
        }

        public void ShowUserView()
        {
            var view = new UserMainView(this);
            var model = new AdminMainModel(session);
            var presenter = new AdminMainPresenter(model, view);

            ShowControl(view);
        }

        public void ShowAddCommodity()
        {
            var view = new AddCommodity(this);
            var model = new AddCommodityModel(session);
            var presenter = new AddCommodityPresenter(model, view);

            ShowControl(view);
            
        }


        //public void ShowAddProduct()
        //{
        //    var view = new AddProduct(this);
        //    var model = new AddProductModel(session);
        //    var presenter = new AddProductPresenter(model, view);

        //    ShowControl(view);
        //}





        private void centerActualView()
        {
            control.Left = (this.Width - control.Width) / 2;
            control.Top = (this.Height - control.Height) / 2;
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            ShowLogin();
        }

        
    }
}
