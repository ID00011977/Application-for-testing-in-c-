using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW.DAL
{
    public class ApplicantList
    {
        public List<Applicant> GetAllApplicants()
        {
            return new ApplicantManager().GetAll();
        }

        public List<Applicant> Sort(ByAttribute attribute)
        {
            var result = GetAllApplicants();

            switch (attribute)
            {
                case ByAttribute.Name:
                    result.Sort(new ByNameComparer());
                    return result;

                case ByAttribute.Test:
                    result.Sort(new ByTestComparer());
                    return result;

                case ByAttribute.Score:
                    result.Sort(new ByScoreComparer());
                    return result;
            }

            //if we are here - something went wrong
            return null;
        }

        private class ByNameComparer : IComparer<Applicant>
        {
            public int Compare(Applicant x, Applicant y)
            {
                return string.Compare(x.Name, y.Name);
            }
        }



        private class ByTestComparer : IComparer<Applicant>
        {
            public int Compare(Applicant x, Applicant y)
            {
                return string.Compare(x.Test, y.Test);
            }
        }

        private class ByScoreComparer : IComparer<Applicant>
        {
            public int Compare(Applicant x, Applicant y)
            {
                return string.Compare(Convert.ToString(x.Score), Convert.ToString(y.Score));
            }
        }

        //Sort Linq
        public List<Applicant> SortLinq(ByAttribute attribute)
        {
            switch (attribute)
            {
                case ByAttribute.Name:
                    return GetAllApplicants().OrderBy(a => a.Name).ToList();
                case ByAttribute.Score:
                    return GetAllApplicants().OrderBy(a => a.Score).ToList();
                case ByAttribute.Test:
                    return GetAllApplicants().OrderBy(a => a.Test).ToList();
            }

           
            return null;
        }
        //For Searching method
        public List<Applicant> Search(string value, ByAttribute attribute)
        {
            switch (attribute)
            {
                case ByAttribute.Name:
                    return GetAllApplicants().Where(a => a.Name.ToUpper().Contains(value.ToUpper())).ToList();
                case ByAttribute.Test:
                    return GetAllApplicants().Where(a => a.Test.ToUpper().Contains(value.ToUpper())).ToList();
                case ByAttribute.Id:
                    return GetAllApplicants().Where(a => Convert.ToString(a.Id) == value).ToList();

            }

            
            return null;
        }
    }
}
