using IT3045_Final_Group4.Models;
using System.Collections.Generic;

namespace IT3045_Final_Group4.Interfaces
{
    public interface ITreeTableContextDAO
    {
        // Get all trees
        List<TreeTableModel> GetAllTrees();

        // Get a specific tree by ID
        TreeTableModel GetTreeById(int id);

        // Add a new tree
        void AddTree(TreeTableModel tree);

        // Update an existing tree
        void UpdateTree(TreeTableModel tree);

        // Delete a tree by ID
        void DeleteTree(int id);
    }
}

