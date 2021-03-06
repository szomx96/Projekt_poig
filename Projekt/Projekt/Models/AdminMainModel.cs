﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projekt.Classes;

namespace Projekt.Models
{
    public class AdminMainModel
    {
        ModelContainer container;
        
        AdminMainModel(){ }

        public AdminMainModel(ModelContainer container)
        {
            this.container = container;
        }

        internal string[] SelectUserInfo()
        {
            string[] info = container.Database.SelectUserInfo(container.LoginID);
            return info;
        }

        internal string GetDate()
        {
            return DateTime.Now.ToString();
        }

        internal List<Route> GetMyOrders(int userID)
        {
            return container.Database.SelectOrdersByID(userID);
        }

    }

}
