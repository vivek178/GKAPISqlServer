using DataAccessLayer;
using Entities;
using System.Collections.Generic;

namespace GKBusinessLayer
{
    public class LabelServiceImplementation : IKeepLabelService
    {

        // create a refrence of IKeepLabel and initialize it.
        private readonly IKeepLabel ikeeplabel;
        // IkeepLabel Initialize.
        public LabelServiceImplementation(IKeepLabel label)
        {
            ikeeplabel = label;
        }


        // create a Label.
        public int CreateLabel(Label label)
        {
            return ikeeplabel.CreateLabel(label);
        }


        // Get all the labels.
        public List<Label> GetLabels()
        {
            return ikeeplabel.GetLabels();
        }
        

        // Remove a label.
        public int RemoveLabel(int LabelID)
        {
            return ikeeplabel.RemoveLabel(LabelID);
        }


        // Update a label.
        public int UpdateLabel(Label label)
        {
            return ikeeplabel.UpdateLabel(label);
        }
    }
}
