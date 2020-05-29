namespace MoC.TypedEntities
{
	/// <summary>
	/// Business that represents a customer or potential customer. The company that is billed in business transactions.
	/// </summary>
	public partial class Account
	{
		
		public enum accountcategorycodeValues
		{
			
			[System.ComponentModel.Description("Preferred Customer")]
			PreferredCustomer = 1,
			
			[System.ComponentModel.Description("Standard")]
			Standard = 2,
		}
		
		public enum accountclassificationcodeValues
		{
			
			[System.ComponentModel.Description("Default Value")]
			DefaultValue = 1,
		}
		
		public enum accountratingcodeValues
		{
			
			[System.ComponentModel.Description("Default Value")]
			DefaultValue = 1,
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
		
		public enum businesstypecodeValues
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
			
			[System.ComponentModel.Description("Competitor")]
			Competitor = 1,
			
			[System.ComponentModel.Description("Consultant")]
			Consultant = 2,
			
			[System.ComponentModel.Description("Customer")]
			Customer = 3,
			
			[System.ComponentModel.Description("Investor")]
			Investor = 4,
			
			[System.ComponentModel.Description("Partner")]
			Partner = 5,
			
			[System.ComponentModel.Description("Influencer")]
			Influencer = 6,
			
			[System.ComponentModel.Description("Press")]
			Press = 7,
			
			[System.ComponentModel.Description("Prospect")]
			Prospect = 8,
			
			[System.ComponentModel.Description("Reseller")]
			Reseller = 9,
			
			[System.ComponentModel.Description("Supplier")]
			Supplier = 10,
			
			[System.ComponentModel.Description("Vendor")]
			Vendor = 11,
			
			[System.ComponentModel.Description("Other")]
			Other = 12,
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
		
		public static class followemailValues
		{
			
			[System.ComponentModel.Description("Do Not Allow")]
			public const bool DoNotAllow = false;
			
			[System.ComponentModel.Description("Allow")]
			public const bool Allow = true;
		}
		
		public enum industrycodeValues
		{
			
			[System.ComponentModel.Description("Accounting")]
			Accounting = 1,
			
			[System.ComponentModel.Description("Agriculture and Non-petrol Natural Resource Extraction")]
			AgricultureandNonpetrolNaturalResourceExtraction = 2,
			
			[System.ComponentModel.Description("Broadcasting Printing and Publishing")]
			BroadcastingPrintingandPublishing = 3,
			
			[System.ComponentModel.Description("Brokers")]
			Brokers = 4,
			
			[System.ComponentModel.Description("Building Supply Retail")]
			BuildingSupplyRetail = 5,
			
			[System.ComponentModel.Description("Business Services")]
			BusinessServices = 6,
			
			[System.ComponentModel.Description("Consulting")]
			Consulting = 7,
			
			[System.ComponentModel.Description("Consumer Services")]
			ConsumerServices = 8,
			
			[System.ComponentModel.Description("Design, Direction and Creative Management")]
			DesignDirectionandCreativeManagement = 9,
			
			[System.ComponentModel.Description("Distributors, Dispatchers and Processors")]
			DistributorsDispatchersandProcessors = 10,
			
			[System.ComponentModel.Description("Doctor\'s Offices and Clinics")]
			DoctorsOfficesandClinics = 11,
			
			[System.ComponentModel.Description("Durable Manufacturing")]
			DurableManufacturing = 12,
			
			[System.ComponentModel.Description("Eating and Drinking Places")]
			EatingandDrinkingPlaces = 13,
			
			[System.ComponentModel.Description("Entertainment Retail")]
			EntertainmentRetail = 14,
			
			[System.ComponentModel.Description("Equipment Rental and Leasing")]
			EquipmentRentalandLeasing = 15,
			
			[System.ComponentModel.Description("Financial")]
			Financial = 16,
			
			[System.ComponentModel.Description("Food and Tobacco Processing")]
			FoodandTobaccoProcessing = 17,
			
			[System.ComponentModel.Description("Inbound Capital Intensive Processing")]
			InboundCapitalIntensiveProcessing = 18,
			
			[System.ComponentModel.Description("Inbound Repair and Services")]
			InboundRepairandServices = 19,
			
			[System.ComponentModel.Description("Insurance")]
			Insurance = 20,
			
			[System.ComponentModel.Description("Legal Services")]
			LegalServices = 21,
			
			[System.ComponentModel.Description("Non-Durable Merchandise Retail")]
			NonDurableMerchandiseRetail = 22,
			
			[System.ComponentModel.Description("Outbound Consumer Service")]
			OutboundConsumerService = 23,
			
			[System.ComponentModel.Description("Petrochemical Extraction and Distribution")]
			PetrochemicalExtractionandDistribution = 24,
			
			[System.ComponentModel.Description("Service Retail")]
			ServiceRetail = 25,
			
			[System.ComponentModel.Description("SIG Affiliations")]
			SIGAffiliations = 26,
			
			[System.ComponentModel.Description("Social Services")]
			SocialServices = 27,
			
			[System.ComponentModel.Description("Special Outbound Trade Contractors")]
			SpecialOutboundTradeContractors = 28,
			
			[System.ComponentModel.Description("Specialty Realty")]
			SpecialtyRealty = 29,
			
			[System.ComponentModel.Description("Transportation")]
			Transportation = 30,
			
			[System.ComponentModel.Description("Utility Creation and Distribution")]
			UtilityCreationandDistribution = 31,
			
			[System.ComponentModel.Description("Vehicle Retail")]
			VehicleRetail = 32,
			
			[System.ComponentModel.Description("Wholesale")]
			Wholesale = 33,
		}
		
		public static class isprivateValues
		{
			
			[System.ComponentModel.Description("No")]
			public const bool No = false;
			
			[System.ComponentModel.Description("Yes")]
			public const bool Yes = true;
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
		
		public enum ownershipcodeValues
		{
			
			[System.ComponentModel.Description("Public")]
			Public = 1,
			
			[System.ComponentModel.Description("Private")]
			Private = 2,
			
			[System.ComponentModel.Description("Subsidiary")]
			Subsidiary = 3,
			
			[System.ComponentModel.Description("Other")]
			Other = 4,
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
