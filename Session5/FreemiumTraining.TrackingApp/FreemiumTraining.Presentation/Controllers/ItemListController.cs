using FreemiumTraining.Business;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace FreemiumTraining.Presentation.Controllers
{
   
    public class ItemListController
    {
        private ITrackableItemManager _item;

        public ItemListController(ITrackableItemManager item){
            this._item = item;


        }

    [HttpGet]
        public void GetItems()
        {
           
            //return null;
        }



    }
}