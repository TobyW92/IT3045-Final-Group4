using IT3045_Final_Group4.Models;
using IT3045_Final_Group4.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace IT3045_Final_Group4.Data
{
    public class TreeTableContextDAO : ITreeTableContextDAO
    {
        private readonly TreeTableContext _context;

        public TreeTableContextDAO(TreeTableContext context)
        {
            _context = context;
        }

        // Get all trees
        public List<TreeTable> GetAllTrees()
        {
            return _context.Trees.ToList();
        }

        // Get tree by id
        public TreeTable GetTreeById(int id)
        {
            return _context.Trees.FirstOrDefault(x => x.Id == id);
        }

        // Add a new tree
        public void AddTree(TreeTable tree)
        {
            _context.Trees.Add(tree);
            _context.SaveChanges();
        }

        // Update an existing tree
        public void UpdateTree(TreeTable tree)
        {
            _context.Trees.Update(tree);
            _context.SaveChanges();
        }

        // Delete a tree by id
        public void DeleteTree(int id)
        {
            var tree = _context.Trees.FirstOrDefault(x => x.Id == id);
            if (tree != null)
            {
                _context.Trees.Remove(tree);
                _context.SaveChanges();
            }
        }
    }
}