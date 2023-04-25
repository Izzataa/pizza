using PizzaMizza.Core.Enums;
using PizzaMizza.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaMizzaApp.Services.Interfaces
{
    public interface IPizzaMizzaService
    {

        public  Task Createasync();




        public  Task Deleteasync();



        public  Task ShowAllasync();


        public Task ShowByIdasync();



        public  Task Updateasync();


    }
}
