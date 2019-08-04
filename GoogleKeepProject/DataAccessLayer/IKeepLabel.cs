using Entities;
using System.Collections.Generic;

namespace DataAccessLayer
{
    /// <summary>
    /// Inteface for Accessing properties of Labels class.
    /// </summary>
    public interface IKeepLabel
    {
        List<Label> GetLabels();

        int CreateLabel(Label label);

        int UpdateLabel(Label label);

        int RemoveLabel(int LabelID);
    }
}
