using IT3045_Final_Group4.Models;
using System.Collections.Generic;

namespace IT3045_Final_Group4.Interfaces
{
    public interface ITreeTableContextDAO
    {
        // Get all trees
        List<TreeTable> GetAllTrees();

        // Get a specific tree by ID
        TreeTable GetTreeById(int id);

        // Add a new tree
        void AddTree(TreeTable tree);

        // Update an existing tree
        void UpdateTree(TreeTable tree);

        // Delete a tree by ID
        void DeleteTree(int id);
    }
}

