﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt
{
    public interface IViewChanger
    {
        void ShowLogin();
        void ShowAdminMain();
        void ShowNewOrder();
        void ShowNewDriver();
        void ShowNewVehicle();
        // void ShowAddProduct();
        void ShowSettings();
          
    }
}
