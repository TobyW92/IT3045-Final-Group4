using IT3045_Final_Group4.Interfaces;
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

        public int? RemoveItemById(int id)
        {
            var team = this.GetItemById(id);

            if (team == null) return null;

            try
            {
                _context.Sample.Remove(team);
                _context.SaveChanges();
                return 1;
            }
            catch (Exception)
            {
                return 0;
            }
        }


        public int? UpdateItem(Sample item)
        {
            var itemToUpdate = this.GetItemById(item.Id);

            if (itemToUpdate == null) return null;

            itemToUpdate.SampleName = item.SampleName;
            if (item.SampleNull != null)
            {
                itemToUpdate.SampleNull = item.SampleNull;
            }


            try
            {
                _context.Sample.Update(itemToUpdate);
                _context.SaveChanges();
                return 1;
            }
            catch (Exception)
            {
                return 0;
            }
        }

        public int? Add(Sample item)
        {
            var itemToAdd = _context.Sample.Where(x => x.SampleName.Equals(item.SampleName)).FirstOrDefault();

            if (itemToAdd != null) return null;

            try
            {
                _context.Sample.Add(item);
                _context.SaveChanges();
                return 1;
            }
            catch (Exception)
            {
                return 0;
            }

        }
    }
}