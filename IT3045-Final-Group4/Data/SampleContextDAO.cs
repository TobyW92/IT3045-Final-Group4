﻿using IT3045_Final_Group4.Interfaces;
using IT3045_Final_Group4.Models;

namespace IT3045_Final_Group4.Data
{
    public class SampleContextDAO : ISampleContextDAO
    {

        private SampleContext _context;
        public SampleContextDAO(SampleContext context)
        {
            _context = context;
        }

        public List<Sample> GetAllItems()
        {
            return _context.Sample.ToList();
        }

        public Sample GetItemById(int id)
        {
            return _context.Sample.Where(x => x.Id.Equals(id)).FirstOrDefault();
        }

        public Sample RemoveItemById(int id)
        {
            var team = this.GetItemById(id);
            if (team == null) return null;
            try
            {
                _context.Sample.Remove(team);
                _context.SaveChanges();
                return team;
            }
            catch (Exception)
            {
                return new Sample();
            }
        }
    }
}
