using Entities;
using System.Collections.Generic;

namespace GKBusinessLayer
{
    /// <summary>
    /// Interface for Accessing the properties of Label Class.
    /// </summary>
    public interface IKeepLabelService
    {
        List<Label> GetLabels();

        int CreateLabel(Label label);

        int UpdateLabel(Label label);

        int RemoveLabel(int LabelID);
    }
}
