using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace VMS.Models
{
    public class CompanyModel
    {
        #region properties
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Contact { get; set; }
        public bool StatusId { get; set; }
        public string ImageUrl { get; set; }
        public string EditedBy { get; set; }
        public DateTime EditedOn { get; set; }
        #endregion properties
        #region Methods
        public async Task<List<CompanyModel>> GetCompanies(bool status)
        {
            using (VmsEntities db = new VmsEntities())
            {
                List<CompanyModel> List = await (from c in db.CompanyMasters
                                                 where c.StatusId == status
                                                 select new CompanyModel
                                                 {
                                                     Name = c.Name,
                                                     Address = c.Address,
                                                     Contact = c.Contact,
                                                     StatusId = c.StatusId,
                                                     ImageUrl = c.ImageUrl,
                                                 }

                        ).ToListAsync();
                return List;
            }
        }
        public async Task<int> Create()
        {
            int result = 0;
            using (VmsEntities db = new VmsEntities())
            {
                CompanyMaster comp = new CompanyMaster();
                var exist = await db.CompanyMasters.Where(x => x.Name == Name).CountAsync();
                if (exist == 0)
                {
                    comp.ID = Guid.NewGuid();
                    comp.Name = Name;
                    comp.Address = Address;
                    comp.Contact = Contact;
                    comp.StatusId = true;
                    comp.ImageUrl = ImageUrl;
                    comp.EditedBy = "System";
                    comp.EditedOn = DateTime.Now;
                    db.CompanyMasters.Add(comp);
                    await db.SaveChangesAsync();
                    result = 1;
                }
                else
                {
                    result = 0;
                }
                return result;
            }

        }

        #endregion Methods
    }
}