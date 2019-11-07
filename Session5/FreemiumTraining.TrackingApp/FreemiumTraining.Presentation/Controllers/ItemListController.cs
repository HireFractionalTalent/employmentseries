using FreemiumTraining.Business;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace FreemiumTraining.Presentation.Controllers
{
   
    public class ItemListController
    {
        private ITrackableItemManager _manager;

        public ItemListController(ITrackableItemManager manager){
            this._manager = manager;

            

        }

    [HttpGet]
        public void Get()
        {
           
            //return null;
        }
    }
}