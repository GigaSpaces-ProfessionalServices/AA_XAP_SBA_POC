using System;
using GigaSpaces.Core.Metadata;

namespace GigaSpaces.Examples.ProcessingUnit.Common
{
	/// <summary>
	/// Represnts a data object
	/// </summary>	
	public class Data
	{
		private String _id;
		private String _key;		
		private Nullable<int> _type;
		private bool _processed;
        private String _AirlineCode;
        private String _FlightNumber;
        private Nullable<DateTime> _FlightOrigDate;
        private String _DepatureStation;
        private Nullable<int> _DuplicateDepartureStationNumber;
        private Nullable<int> _DuplicateArrivalStationNumber;
        private Nullable<char> _FlightLegStatus;




        public Data(){}

		public Data(string key, Nullable<int> type)
		{
			_key = key;
			_type = type;
			_processed = false;
		}
		
		[SpaceID(AutoGenerate=true)]
        public String Id
        {
            get { return _id; }
            set { _id = value; }
        }

		/// <summary>
		/// Gets the data type, used as the routing index inside the cluster
		/// </summary>
		[SpaceRouting]
		public Nullable<int> Type
		{
			get { return _type; }
			set { _type = value; }
		}
		/// <summary>
		/// Gets the data info
		/// </summary>
		public string Key
		{
			get { return _key; }
			set { _key = value; }
		}
		/// <summary>
		/// Gets or sets the data processed state
		/// </summary>
		public bool Processed
		{
			get { return _processed; }
			set { _processed = value; }
		}

        public string AirlineCode
        {
            get { return _AirlineCode; }
            set { _AirlineCode = value; }
        }
        public string FlightNumber
        {
            get { return _FlightNumber; }
            set { _FlightNumber = value; }
        }

        public Nullable<DateTime> FlightOrigDate
        {
            get { return _FlightOrigDate; }
            set { _FlightOrigDate = value; }
        }


        public string DepatureStation
        {
            get { return _DepatureStation; }
            set { _DepatureStation = value; }
        }


        public Nullable<int> DuplicateDepartureStationNumber
        {
            get { return _DuplicateDepartureStationNumber; }
            set { _DuplicateDepartureStationNumber = value; }
        }


        public Nullable<int> DuplicateArrivalStationNumber
        {
            get { return _DuplicateArrivalStationNumber; }
            set { _DuplicateArrivalStationNumber = value; }

        }

        public Nullable<char> FlightLegStatus
        {
            get { return _FlightLegStatus; }
            set { _FlightLegStatus = value; }
        }

    }
}