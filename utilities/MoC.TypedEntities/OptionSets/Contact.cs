namespace MoC.TypedEntities
{
	/// <summary>
	/// Person with whom a business unit has a relationship, such as customer, supplier, and colleague.
	/// </summary>
	public partial class Contact
	{
		
		public enum accountrolecodeValues
		{
			
			[System.ComponentModel.Description("Decision Maker")]
			DecisionMaker = 1,
			
			[System.ComponentModel.Description("Employee")]
			Employee = 2,
			
			[System.ComponentModel.Description("Influencer")]
			Influencer = 3,
		}
		
		public enum address1_addresstypecodeValues
		{
			
			[System.ComponentModel.Description("Bill To")]
			BillTo = 1,
			
			[System.ComponentModel.Description("Ship To")]
			ShipTo = 2,
			
			[System.ComponentModel.Description("Primary")]
			Primary = 3,
			
			[System.ComponentModel.Description("Other")]
			Other = 4,
		}
		
		public enum address1_freighttermscodeValues
		{
			
			[System.ComponentModel.Description("FOB")]
			FOB = 1,
			
			[System.ComponentModel.Description("No Charge")]
			NoCharge = 2,
		}
		
		public enum address1_shippingmethodcodeValues
		{
			
			[System.ComponentModel.Description("Airborne")]
			Airborne = 1,
			
			[System.ComponentModel.Description("DHL")]
			DHL = 2,
			
			[System.ComponentModel.Description("FedEx")]
			FedEx = 3,
			
			[System.ComponentModel.Description("UPS")]
			UPS = 4,
			
			[System.ComponentModel.Description("Postal Mail")]
			PostalMail = 5,
			
			[System.ComponentModel.Description("Full Load")]
			FullLoad = 6,
			
			[System.ComponentModel.Description("Will Call")]
			WillCall = 7,
		}
		
		public enum address2_addresstypecodeValues
		{
			
			[System.ComponentModel.Description("Default Value")]
			DefaultValue = 1,
		}
		
		public enum address2_freighttermscodeValues
		{
			
			[System.ComponentModel.Description("Default Value")]
			DefaultValue = 1,
		}
		
		public enum address2_shippingmethodcodeValues
		{
			
			[System.ComponentModel.Description("Default Value")]
			DefaultValue = 1,
		}
		
		public enum address3_addresstypecodeValues
		{
			
			[System.ComponentModel.Description("Default Value")]
			DefaultValue = 1,
		}
		
		public enum address3_freighttermscodeValues
		{
			
			[System.ComponentModel.Description("Default Value")]
			DefaultValue = 1,
		}
		
		public enum address3_shippingmethodcodeValues
		{
			
			[System.ComponentModel.Description("Default Value")]
			DefaultValue = 1,
		}
		
		public static class creditonholdValues
		{
			
			[System.ComponentModel.Description("No")]
			public const bool No = false;
			
			[System.ComponentModel.Description("Yes")]
			public const bool Yes = true;
		}
		
		public enum customersizecodeValues
		{
			
			[System.ComponentModel.Description("Default Value")]
			DefaultValue = 1,
		}
		
		public enum customertypecodeValues
		{
			
			[System.ComponentModel.Description("Default Value")]
			DefaultValue = 1,
		}
		
		public static class donotbulkemailValues
		{
			
			[System.ComponentModel.Description("Allow")]
			public const bool Allow = false;
			
			[System.ComponentModel.Description("Do Not Allow")]
			public const bool DoNotAllow = true;
		}
		
		public static class donotbulkpostalmailValues
		{
			
			[System.ComponentModel.Description("No")]
			public const bool No = false;
			
			[System.ComponentModel.Description("Yes")]
			public const bool Yes = true;
		}
		
		public static class donotemailValues
		{
			
			[System.ComponentModel.Description("Allow")]
			public const bool Allow = false;
			
			[System.ComponentModel.Description("Do Not Allow")]
			public const bool DoNotAllow = true;
		}
		
		public static class donotfaxValues
		{
			
			[System.ComponentModel.Description("Allow")]
			public const bool Allow = false;
			
			[System.ComponentModel.Description("Do Not Allow")]
			public const bool DoNotAllow = true;
		}
		
		public static class donotphoneValues
		{
			
			[System.ComponentModel.Description("Allow")]
			public const bool Allow = false;
			
			[System.ComponentModel.Description("Do Not Allow")]
			public const bool DoNotAllow = true;
		}
		
		public static class donotpostalmailValues
		{
			
			[System.ComponentModel.Description("Allow")]
			public const bool Allow = false;
			
			[System.ComponentModel.Description("Do Not Allow")]
			public const bool DoNotAllow = true;
		}
		
		public static class donotsendmmValues
		{
			
			[System.ComponentModel.Description("Send")]
			public const bool Send = false;
			
			[System.ComponentModel.Description("Do Not Send")]
			public const bool DoNotSend = true;
		}
		
		public enum educationcodeValues
		{
			
			[System.ComponentModel.Description("Default Value")]
			DefaultValue = 1,
		}
		
		public enum familystatuscodeValues
		{
			
			[System.ComponentModel.Description("Single")]
			Single = 1,
			
			[System.ComponentModel.Description("Married")]
			Married = 2,
			
			[System.ComponentModel.Description("Divorced")]
			Divorced = 3,
			
			[System.ComponentModel.Description("Widowed")]
			Widowed = 4,
		}
		
		public static class followemailValues
		{
			
			[System.ComponentModel.Description("Do Not Allow")]
			public const bool DoNotAllow = false;
			
			[System.ComponentModel.Description("Allow")]
			public const bool Allow = true;
		}
		
		public enum gendercodeValues
		{
			
			[System.ComponentModel.Description("Male")]
			Male = 1,
			
			[System.ComponentModel.Description("Female")]
			Female = 2,
		}
		
		public enum haschildrencodeValues
		{
			
			[System.ComponentModel.Description("Default Value")]
			DefaultValue = 1,
		}
		
		public static class isautocreateValues
		{
			
			[System.ComponentModel.Description("No")]
			public const bool No = false;
			
			[System.ComponentModel.Description("Yes")]
			public const bool Yes = true;
		}
		
		public static class isbackofficecustomerValues
		{
			
			[System.ComponentModel.Description("No")]
			public const bool No = false;
			
			[System.ComponentModel.Description("Yes")]
			public const bool Yes = true;
		}
		
		public static class isprivateValues
		{
			
			[System.ComponentModel.Description("No")]
			public const bool No = false;
			
			[System.ComponentModel.Description("Yes")]
			public const bool Yes = true;
		}
		
		public enum leadsourcecodeValues
		{
			
			[System.ComponentModel.Description("Default Value")]
			DefaultValue = 1,
		}
		
		public static class marketingonlyValues
		{
			
			[System.ComponentModel.Description("No")]
			public const bool No = false;
			
			[System.ComponentModel.Description("Yes")]
			public const bool Yes = true;
		}
		
		public static class mergedValues
		{
			
			[System.ComponentModel.Description("No")]
			public const bool No = false;
			
			[System.ComponentModel.Description("Yes")]
			public const bool Yes = true;
		}
		
		public static class msdyn_gdproptoutValues
		{
			
			[System.ComponentModel.Description("No")]
			public const bool No = false;
			
			[System.ComponentModel.Description("Yes")]
			public const bool Yes = true;
		}
		
		public enum msdyn_orgchangestatusValues
		{
			
			[System.ComponentModel.Description("No Feedback")]
			NoFeedback = 0,
			
			[System.ComponentModel.Description("Not at Company")]
			NotatCompany = 1,
			
			[System.ComponentModel.Description("Ignore")]
			Ignore = 2,
		}
		
		public static class participatesinworkflowValues
		{
			
			[System.ComponentModel.Description("No")]
			public const bool No = false;
			
			[System.ComponentModel.Description("Yes")]
			public const bool Yes = true;
		}
		
		public enum paymenttermscodeValues
		{
			
			[System.ComponentModel.Description("Net 30")]
			Net30 = 1,
			
			[System.ComponentModel.Description("2% 10, Net 30")]
			_210Net30 = 2,
			
			[System.ComponentModel.Description("Net 45")]
			Net45 = 3,
			
			[System.ComponentModel.Description("Net 60")]
			Net60 = 4,
		}
		
		public enum preferredappointmentdaycodeValues
		{
			
			[System.ComponentModel.Description("Sunday")]
			Sunday = 0,
			
			[System.ComponentModel.Description("Monday")]
			Monday = 1,
			
			[System.ComponentModel.Description("Tuesday")]
			Tuesday = 2,
			
			[System.ComponentModel.Description("Wednesday")]
			Wednesday = 3,
			
			[System.ComponentModel.Description("Thursday")]
			Thursday = 4,
			
			[System.ComponentModel.Description("Friday")]
			Friday = 5,
			
			[System.ComponentModel.Description("Saturday")]
			Saturday = 6,
		}
		
		public enum preferredappointmenttimecodeValues
		{
			
			[System.ComponentModel.Description("Morning")]
			Morning = 1,
			
			[System.ComponentModel.Description("Afternoon")]
			Afternoon = 2,
			
			[System.ComponentModel.Description("Evening")]
			Evening = 3,
		}
		
		public enum preferredcontactmethodcodeValues
		{
			
			[System.ComponentModel.Description("Any")]
			Any = 1,
			
			[System.ComponentModel.Description("Email")]
			Email = 2,
			
			[System.ComponentModel.Description("Phone")]
			Phone = 3,
			
			[System.ComponentModel.Description("Fax")]
			Fax = 4,
			
			[System.ComponentModel.Description("Mail")]
			Mail = 5,
		}
		
		public enum shippingmethodcodeValues
		{
			
			[System.ComponentModel.Description("Default Value")]
			DefaultValue = 1,
		}
		
		public enum statecodeValues
		{
			
			[System.ComponentModel.Description("Active")]
			Active = 0,
			
			[System.ComponentModel.Description("Inactive")]
			Inactive = 1,
		}
		
		public enum statuscodeValues
		{
			
			[System.ComponentModel.Description("Active")]
			Active = 1,
			
			[System.ComponentModel.Description("Inactive")]
			Inactive = 2,
		}
		
		public enum territorycodeValues
		{
			
			[System.ComponentModel.Description("Default Value")]
			DefaultValue = 1,
		}
	}
}
