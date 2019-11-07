using System.Collections.Generic;
using FreemiumTraining.Business;
using FreemiumTraining.DTO;

namespace FreemiumTraining.Business
{
    public interface ITrackableItemManager
    {
    List<TrackableItem> GetItems();

    TrackableItem GetItem(int id);

    bool UpdateItem(TrackableItem item);

    bool DeleteItem(TrackableItem item);

    bool IsItemExist(int id);


    
    }
}