using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace Tour_Manager_Sever_Side.Objects
{
    public class Crew
    {
        #region private field

        private int crewId;

        private DateTime startDate;

        private DateTime endDate;

        private string info;

        private int tourId;



        #endregion

        #region get, set 

        public int CrewId
        {
            get
            {
                return this.crewId;
            }

            set
            {
                this.crewId = value;
            }
        }

        public DateTime StartDate
        {
            get
            {
                return this.startDate;
            }

            set
            {
                this.startDate = value;
            }
        }

        public DateTime EndDate
        {
            get
            {
                return this.endDate;
            }

            set
            {
                endDate = value;
            }
        }

        public string Info
        { 
            get
            {
                return this.info;
            }

            set
            {
                this.info = value;
            }
        }

        public int TourId
        {
            get
            {
                return this.tourId;
            }

            set
            {
                this.tourId = value;
            }
        }
        #endregion

        #region Constructor

        public Crew (int crewid, DateTime start, DateTime end, string info)
        {
            CrewId = crewid;

            StartDate = start;

            EndDate = end;

            Info = info; 
        }
        public Crew(DataRow row)
        {
            CrewId = row["id_doan"].GetHashCode();

            StartDate = Convert.ToDateTime(row["ngay_bat_dau"]);

            EndDate = Convert.ToDateTime(row["ngay_ket_thuc"]);

            Info = row["thong_tin"].ToString();

            tourId = row["id_tour"].GetHashCode();
        }

        #endregion

    }
}
