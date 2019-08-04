using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GKBusinessLayer
{
    public interface IKeepLabelService
    {
        List<Label> GetLabels();

        int CreateLabel(Label label);

        int UpdateLabel(Label label);

        int RemoveLabel(int LabelID);
    }
}
