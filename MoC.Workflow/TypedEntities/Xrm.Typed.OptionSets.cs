//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MoC.Workflow.Entities
{
	
	
	/// <summary>
	/// Active path associated with every Business Process Flow instance
	/// </summary>
	public partial class BusinessProcessFlowInstance
	{
		
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
			
			[System.ComponentModel.Description("Finished")]
			Finished = 2,
			
			[System.ComponentModel.Description("Aborted")]
			Aborted = 3,
		}
	}
	
	/// <summary>
	/// Calendar used by the scheduling system to define when an appointment or activity is to occur.
	/// </summary>
	public partial class Calendar
	{
		
		#region 
	static
		public class issharedValues
		{
			
			[System.ComponentModel.Description("No")]
			public const bool No = false;
			
			[System.ComponentModel.Description("Yes")]
			public const bool Yes = true;
		}
		#endregion
		
		public enum typeValues
		{
			
			[System.ComponentModel.Description("Default")]
			Default = 0,
			
			[System.ComponentModel.Description("Customer Service")]
			CustomerService = 1,
			
			[System.ComponentModel.Description("Holiday Schedule")]
			HolidaySchedule = 2,
			
			[System.ComponentModel.Description("Inner Calendar type")]
			InnerCalendartype = -1,
		}
	}
	
	/// <summary>
	/// Defines free/busy times for a service and for resources or resource groups, such as working, non-working, vacation, and blocked.
	/// </summary>
	public partial class CalendarRule
	{
		
		#region 
	static
		public class ismodifiedValues
		{
			
			[System.ComponentModel.Description("No")]
			public const bool No = false;
			
			[System.ComponentModel.Description("Yes")]
			public const bool Yes = true;
		}
		#endregion
		
		#region 
	static
		public class isselectedValues
		{
			
			[System.ComponentModel.Description("No")]
			public const bool No = false;
			
			[System.ComponentModel.Description("Yes")]
			public const bool Yes = true;
		}
		#endregion
		
		#region 
	static
		public class issimpleValues
		{
			
			[System.ComponentModel.Description("No")]
			public const bool No = false;
			
			[System.ComponentModel.Description("Yes")]
			public const bool Yes = true;
		}
		#endregion
		
		#region 
	static
		public class isvariedValues
		{
			
			[System.ComponentModel.Description("No")]
			public const bool No = false;
			
			[System.ComponentModel.Description("Yes")]
			public const bool Yes = true;
		}
		#endregion
	}
	
	/// <summary>
	/// Activity that is delivered using email protocols.
	/// </summary>
	public partial class Email
	{
		
		#region 
	static
		public class compressedValues
		{
			
			[System.ComponentModel.Description("Not compressed")]
			public const bool Notcompressed = false;
			
			[System.ComponentModel.Description("Compressed")]
			public const bool Compressed = true;
		}
		#endregion
		
		public enum correlationmethodValues
		{
			
			[System.ComponentModel.Description("None")]
			None = 0,
			
			[System.ComponentModel.Description("Skipped")]
			Skipped = 1,
			
			[System.ComponentModel.Description("XHeader")]
			XHeader = 2,
			
			[System.ComponentModel.Description("InReplyTo")]
			InReplyTo = 3,
			
			[System.ComponentModel.Description("TrackingToken")]
			TrackingToken = 4,
			
			[System.ComponentModel.Description("ConversationIndex")]
			ConversationIndex = 5,
			
			[System.ComponentModel.Description("SmartMatching")]
			SmartMatching = 6,
			
			[System.ComponentModel.Description("CustomCorrelation")]
			CustomCorrelation = 7,
		}
		
		public enum deliveryprioritycodeValues
		{
			
			[System.ComponentModel.Description("Low")]
			Low = 0,
			
			[System.ComponentModel.Description("Normal")]
			Normal = 1,
			
			[System.ComponentModel.Description("High")]
			High = 2,
		}
		
		#region 
	static
		public class deliveryreceiptrequestedValues
		{
			
			[System.ComponentModel.Description("No")]
			public const bool No = false;
			
			[System.ComponentModel.Description("Yes")]
			public const bool Yes = true;
		}
		#endregion
		
		#region 
	static
		public class directioncodeValues
		{
			
			[System.ComponentModel.Description("Incoming")]
			public const bool Incoming = false;
			
			[System.ComponentModel.Description("Outgoing")]
			public const bool Outgoing = true;
		}
		#endregion
		
		public enum emailreminderstatusValues
		{
			
			[System.ComponentModel.Description("NotSet")]
			NotSet = 0,
			
			[System.ComponentModel.Description("ReminderSet")]
			ReminderSet = 1,
			
			[System.ComponentModel.Description("ReminderExpired")]
			ReminderExpired = 2,
			
			[System.ComponentModel.Description("ReminderInvalid")]
			ReminderInvalid = 3,
		}
		
		public enum emailremindertypeValues
		{
			
			[System.ComponentModel.Description("If I do not receive a reply by")]
			IfIdonotreceiveareplyby = 0,
			
			[System.ComponentModel.Description("If the email is not opened by")]
			Iftheemailisnotopenedby = 1,
			
			[System.ComponentModel.Description("Remind me anyways at")]
			Remindmeanywaysat = 2,
		}
		
		#region 
	static
		public class followemailuserpreferenceValues
		{
			
			[System.ComponentModel.Description("False")]
			public const bool False = false;
			
			[System.ComponentModel.Description("True")]
			public const bool True = true;
		}
		#endregion
		
		#region 
	static
		public class isbilledValues
		{
			
			[System.ComponentModel.Description("No")]
			public const bool No = false;
			
			[System.ComponentModel.Description("Yes")]
			public const bool Yes = true;
		}
		#endregion
		
		#region 
	static
		public class isemailfollowedValues
		{
			
			[System.ComponentModel.Description("No")]
			public const bool No = false;
			
			[System.ComponentModel.Description("Yes")]
			public const bool Yes = true;
		}
		#endregion
		
		#region 
	static
		public class isemailremindersetValues
		{
			
			[System.ComponentModel.Description("No")]
			public const bool No = false;
			
			[System.ComponentModel.Description("Yes")]
			public const bool Yes = true;
		}
		#endregion
		
		#region 
	static
		public class isregularactivityValues
		{
			
			[System.ComponentModel.Description("No")]
			public const bool No = false;
			
			[System.ComponentModel.Description("Yes")]
			public const bool Yes = true;
		}
		#endregion
		
		#region 
	static
		public class isworkflowcreatedValues
		{
			
			[System.ComponentModel.Description("No")]
			public const bool No = false;
			
			[System.ComponentModel.Description("Yes")]
			public const bool Yes = true;
		}
		#endregion
		
		public enum notificationsValues
		{
			
			[System.ComponentModel.Description("None")]
			None = 0,
			
			[System.ComponentModel.Description("The message was saved as a Microsoft Dynamics 365 email record, but not all the a" +
				"ttachments could be saved with it. An attachment cannot be saved if it is blocke" +
				"d or if its file type is invalid.")]
			ThemessagewassavedasaMicrosoftDynamics365emailrecordbutnotalltheattachmentscouldbesavedwithitAnattachmentcannotbesavedifitisblockedorifitsfiletypeisinvalid = 1,
			
			[System.ComponentModel.Description("Truncated body.")]
			Truncatedbody = 2,
		}
		
		public enum prioritycodeValues
		{
			
			[System.ComponentModel.Description("Low")]
			Low = 0,
			
			[System.ComponentModel.Description("Normal")]
			Normal = 1,
			
			[System.ComponentModel.Description("High")]
			High = 2,
		}
		
		#region 
	static
		public class readreceiptrequestedValues
		{
			
			[System.ComponentModel.Description("No")]
			public const bool No = false;
			
			[System.ComponentModel.Description("Yes")]
			public const bool Yes = true;
		}
		#endregion
		
		public enum statecodeValues
		{
			
			[System.ComponentModel.Description("Open")]
			Open = 0,
			
			[System.ComponentModel.Description("Completed")]
			Completed = 1,
			
			[System.ComponentModel.Description("Canceled")]
			Canceled = 2,
		}
		
		public enum statuscodeValues
		{
			
			[System.ComponentModel.Description("Draft")]
			Draft = 1,
			
			[System.ComponentModel.Description("Completed")]
			Completed = 2,
			
			[System.ComponentModel.Description("Sent")]
			Sent = 3,
			
			[System.ComponentModel.Description("Received")]
			Received = 4,
			
			[System.ComponentModel.Description("Canceled")]
			Canceled = 5,
			
			[System.ComponentModel.Description("Pending Send")]
			PendingSend = 6,
			
			[System.ComponentModel.Description("Sending")]
			Sending = 7,
			
			[System.ComponentModel.Description("Failed")]
			Failed = 8,
		}
	}
	
	/// <summary>
	/// Stage associated with a process.
	/// </summary>
	public partial class ProcessStage
	{
		
		#region 
	static
		public class istriggerValues
		{
			
			[System.ComponentModel.Description("No")]
			public const bool No = false;
			
			[System.ComponentModel.Description("Yes")]
			public const bool Yes = true;
		}
		#endregion
		
		public enum operationkindValues
		{
			
			[System.ComponentModel.Description("Http")]
			Http = 473330000,
			
			[System.ComponentModel.Description("PowerApp")]
			PowerApp = 473330001,
			
			[System.ComponentModel.Description("PowerAppV2")]
			PowerAppV2 = 473330002,
			
			[System.ComponentModel.Description("Button")]
			Button = 473330003,
			
			[System.ComponentModel.Description("ApiConnection")]
			ApiConnection = 473330004,
			
			[System.ComponentModel.Description("Alert")]
			Alert = 473330005,
			
			[System.ComponentModel.Description("EventGrid")]
			EventGrid = 473330006,
			
			[System.ComponentModel.Description("CurrentTime")]
			CurrentTime = 473330007,
			
			[System.ComponentModel.Description("ConvertTimeZone")]
			ConvertTimeZone = 473330008,
			
			[System.ComponentModel.Description("GetFutureTime")]
			GetFutureTime = 473330009,
			
			[System.ComponentModel.Description("GetPastTime")]
			GetPastTime = 473330010,
			
			[System.ComponentModel.Description("AddToTime")]
			AddToTime = 473330011,
			
			[System.ComponentModel.Description("SubtractFromTime")]
			SubtractFromTime = 473330012,
			
			[System.ComponentModel.Description("AzureMonitorAlert")]
			AzureMonitorAlert = 473330013,
			
			[System.ComponentModel.Description("SecurityCenterAlert")]
			SecurityCenterAlert = 473330014,
			
			[System.ComponentModel.Description("JsonToJson")]
			JsonToJson = 473330015,
			
			[System.ComponentModel.Description("JsonToText")]
			JsonToText = 473330016,
			
			[System.ComponentModel.Description("XmlToJson")]
			XmlToJson = 473330017,
			
			[System.ComponentModel.Description("XmlToText")]
			XmlToText = 473330018,
			
			[System.ComponentModel.Description("Geofence")]
			Geofence = 473330019,
			
			[System.ComponentModel.Description("ODataOpenApiConnection")]
			ODataOpenApiConnection = 473330020,
			
			[System.ComponentModel.Description("IndexOf")]
			IndexOf = 473330021,
			
			[System.ComponentModel.Description("Substring")]
			Substring = 473330022,
			
			[System.ComponentModel.Description("VirtualAgent")]
			VirtualAgent = 473330023,
			
			[System.ComponentModel.Description("FormatNumber")]
			FormatNumber = 473330024,
		}
		
		public enum operationtypeValues
		{
			
			[System.ComponentModel.Description("Http")]
			Http = 473330000,
			
			[System.ComponentModel.Description("ApiApp")]
			ApiApp = 473330001,
			
			[System.ComponentModel.Description("Recurrence")]
			Recurrence = 473330002,
			
			[System.ComponentModel.Description("Workflow")]
			Workflow = 473330003,
			
			[System.ComponentModel.Description("Flow")]
			Flow = 473330004,
			
			[System.ComponentModel.Description("Wait")]
			Wait = 473330005,
			
			[System.ComponentModel.Description("ApiConnection")]
			ApiConnection = 473330006,
			
			[System.ComponentModel.Description("OpenApiConnection")]
			OpenApiConnection = 473330007,
			
			[System.ComponentModel.Description("Manual")]
			Manual = 473330008,
			
			[System.ComponentModel.Description("ApiConnectionWebhook")]
			ApiConnectionWebhook = 473330009,
			
			[System.ComponentModel.Description("OpenApiConnectionWebhook")]
			OpenApiConnectionWebhook = 473330010,
			
			[System.ComponentModel.Description("Response")]
			Response = 473330011,
			
			[System.ComponentModel.Description("HttpWebhook")]
			HttpWebhook = 473330012,
			
			[System.ComponentModel.Description("Compose")]
			Compose = 473330013,
			
			[System.ComponentModel.Description("Query")]
			Query = 473330014,
			
			[System.ComponentModel.Description("Function")]
			Function = 473330015,
			
			[System.ComponentModel.Description("ApiManagement")]
			ApiManagement = 473330016,
			
			[System.ComponentModel.Description("XmlValidation")]
			XmlValidation = 473330017,
			
			[System.ComponentModel.Description("FlatFileEncoding")]
			FlatFileEncoding = 473330018,
			
			[System.ComponentModel.Description("Scope")]
			Scope = 473330019,
			
			[System.ComponentModel.Description("Request")]
			Request = 473330020,
			
			[System.ComponentModel.Description("If")]
			If = 473330021,
			
			[System.ComponentModel.Description("Foreach")]
			Foreach = 473330022,
			
			[System.ComponentModel.Description("Until")]
			Until = 473330023,
			
			[System.ComponentModel.Description("Xslt")]
			Xslt = 473330024,
			
			[System.ComponentModel.Description("FlatFileDecoding")]
			FlatFileDecoding = 473330025,
			
			[System.ComponentModel.Description("Terminate")]
			Terminate = 473330026,
			
			[System.ComponentModel.Description("IntegrationAccountArtifactLookup")]
			IntegrationAccountArtifactLookup = 473330027,
			
			[System.ComponentModel.Description("Switch")]
			Switch = 473330028,
			
			[System.ComponentModel.Description("ParseJson")]
			ParseJson = 473330029,
			
			[System.ComponentModel.Description("Table")]
			Table = 473330030,
			
			[System.ComponentModel.Description("Join")]
			Join = 473330031,
			
			[System.ComponentModel.Description("Select")]
			Select = 473330032,
			
			[System.ComponentModel.Description("InitializeVariable")]
			InitializeVariable = 473330033,
			
			[System.ComponentModel.Description("IncrementVariable")]
			IncrementVariable = 473330034,
			
			[System.ComponentModel.Description("DecrementVariable")]
			DecrementVariable = 473330035,
			
			[System.ComponentModel.Description("SetVariable")]
			SetVariable = 473330036,
			
			[System.ComponentModel.Description("AppendToArrayVariable")]
			AppendToArrayVariable = 473330037,
			
			[System.ComponentModel.Description("AppendToStringVariable")]
			AppendToStringVariable = 473330038,
			
			[System.ComponentModel.Description("Batch")]
			Batch = 473330039,
			
			[System.ComponentModel.Description("SendToBatch")]
			SendToBatch = 473330040,
			
			[System.ComponentModel.Description("SlidingWindow")]
			SlidingWindow = 473330041,
			
			[System.ComponentModel.Description("Expression")]
			Expression = 473330042,
			
			[System.ComponentModel.Description("Liquid")]
			Liquid = 473330043,
			
			[System.ComponentModel.Description("JavascriptCode")]
			JavascriptCode = 473330044,
			
			[System.ComponentModel.Description("As2Decode")]
			As2Decode = 473330045,
			
			[System.ComponentModel.Description("As2Encode")]
			As2Encode = 473330046,
			
			[System.ComponentModel.Description("RosettaNetEncode")]
			RosettaNetEncode = 473330047,
			
			[System.ComponentModel.Description("RosettaNetDecode")]
			RosettaNetDecode = 473330048,
			
			[System.ComponentModel.Description("RosettaNetWaitForResponse")]
			RosettaNetWaitForResponse = 473330049,
			
			[System.ComponentModel.Description("ApiConnectionNotification")]
			ApiConnectionNotification = 473330050,
			
			[System.ComponentModel.Description("Changeset")]
			Changeset = 473330051,
			
			[System.ComponentModel.Description("SwiftEncode")]
			SwiftEncode = 473330052,
		}
		
		public enum stagecategoryValues
		{
			
			[System.ComponentModel.Description("Qualify")]
			Qualify = 0,
			
			[System.ComponentModel.Description("Develop")]
			Develop = 1,
			
			[System.ComponentModel.Description("Propose")]
			Propose = 2,
			
			[System.ComponentModel.Description("Close")]
			Close = 3,
			
			[System.ComponentModel.Description("Identify")]
			Identify = 4,
			
			[System.ComponentModel.Description("Research")]
			Research = 5,
			
			[System.ComponentModel.Description("Resolve")]
			Resolve = 6,
			
			[System.ComponentModel.Description("Approval")]
			Approval = 7,
		}
	}
	
	/// <summary>
	/// Person with access to the Microsoft CRM system and who owns objects in the Microsoft CRM database.
	/// </summary>
	public partial class SystemUser
	{
		
		public enum accessmodeValues
		{
			
			[System.ComponentModel.Description("Read-Write")]
			ReadWrite = 0,
			
			[System.ComponentModel.Description("Administrative")]
			Administrative = 1,
			
			[System.ComponentModel.Description("Read")]
			Read = 2,
			
			[System.ComponentModel.Description("Support User")]
			SupportUser = 3,
			
			[System.ComponentModel.Description("Non-interactive")]
			Noninteractive = 4,
			
			[System.ComponentModel.Description("Delegated Admin")]
			DelegatedAdmin = 5,
		}
		
		public enum address1_addresstypecodeValues
		{
			
			[System.ComponentModel.Description("Default Value")]
			DefaultValue = 1,
		}
		
		public enum address1_shippingmethodcodeValues
		{
			
			[System.ComponentModel.Description("Default Value")]
			DefaultValue = 1,
		}
		
		public enum address2_addresstypecodeValues
		{
			
			[System.ComponentModel.Description("Default Value")]
			DefaultValue = 1,
		}
		
		public enum address2_shippingmethodcodeValues
		{
			
			[System.ComponentModel.Description("Default Value")]
			DefaultValue = 1,
		}
		
		public enum caltypeValues
		{
			
			[System.ComponentModel.Description("Professional")]
			Professional = 0,
			
			[System.ComponentModel.Description("Administrative")]
			Administrative = 1,
			
			[System.ComponentModel.Description("Basic")]
			Basic = 2,
			
			[System.ComponentModel.Description("Device Professional")]
			DeviceProfessional = 3,
			
			[System.ComponentModel.Description("Device Basic")]
			DeviceBasic = 4,
			
			[System.ComponentModel.Description("Essential")]
			Essential = 5,
			
			[System.ComponentModel.Description("Device Essential")]
			DeviceEssential = 6,
			
			[System.ComponentModel.Description("Enterprise")]
			Enterprise = 7,
			
			[System.ComponentModel.Description("Device Enterprise")]
			DeviceEnterprise = 8,
			
			[System.ComponentModel.Description("Sales")]
			Sales = 9,
			
			[System.ComponentModel.Description("Service")]
			Service = 10,
			
			[System.ComponentModel.Description("Field Service")]
			FieldService = 11,
			
			[System.ComponentModel.Description("Project Service")]
			ProjectService = 12,
		}
		
		#region 
	static
		public class defaultfilterspopulatedValues
		{
			
			[System.ComponentModel.Description("No")]
			public const bool No = false;
			
			[System.ComponentModel.Description("Yes")]
			public const bool Yes = true;
		}
		#endregion
		
		#region 
	static
		public class displayinserviceviewsValues
		{
			
			[System.ComponentModel.Description("No")]
			public const bool No = false;
			
			[System.ComponentModel.Description("Yes")]
			public const bool Yes = true;
		}
		#endregion
		
		public enum emailrouteraccessapprovalValues
		{
			
			[System.ComponentModel.Description("Empty")]
			Empty = 0,
			
			[System.ComponentModel.Description("Approved")]
			Approved = 1,
			
			[System.ComponentModel.Description("Pending Approval")]
			PendingApproval = 2,
			
			[System.ComponentModel.Description("Rejected")]
			Rejected = 3,
		}
		
		public enum incomingemaildeliverymethodValues
		{
			
			[System.ComponentModel.Description("None")]
			None = 0,
			
			[System.ComponentModel.Description("Microsoft Dynamics 365 for Outlook")]
			MicrosoftDynamics365forOutlook = 1,
			
			[System.ComponentModel.Description("Server-Side Synchronization or Email Router")]
			ServerSideSynchronizationorEmailRouter = 2,
			
			[System.ComponentModel.Description("Forward Mailbox")]
			ForwardMailbox = 3,
		}
		
		public enum invitestatuscodeValues
		{
			
			[System.ComponentModel.Description("Invitation Not Sent")]
			InvitationNotSent = 0,
			
			[System.ComponentModel.Description("Invited")]
			Invited = 1,
			
			[System.ComponentModel.Description("Invitation Near Expired")]
			InvitationNearExpired = 2,
			
			[System.ComponentModel.Description("Invitation Expired")]
			InvitationExpired = 3,
			
			[System.ComponentModel.Description("Invitation Accepted")]
			InvitationAccepted = 4,
			
			[System.ComponentModel.Description("Invitation Rejected")]
			InvitationRejected = 5,
			
			[System.ComponentModel.Description("Invitation Revoked")]
			InvitationRevoked = 6,
		}
		
		#region 
	static
		public class isactivedirectoryuserValues
		{
			
			[System.ComponentModel.Description("No")]
			public const bool No = false;
			
			[System.ComponentModel.Description("Yes")]
			public const bool Yes = true;
		}
		#endregion
		
		#region 
	static
		public class isdisabledValues
		{
			
			[System.ComponentModel.Description("Enabled")]
			public const bool Enabled = false;
			
			[System.ComponentModel.Description("Disabled")]
			public const bool Disabled = true;
		}
		#endregion
		
		#region 
	static
		public class isemailaddressapprovedbyo365adminValues
		{
			
			[System.ComponentModel.Description("No")]
			public const bool No = false;
			
			[System.ComponentModel.Description("Yes")]
			public const bool Yes = true;
		}
		#endregion
		
		#region 
	static
		public class isintegrationuserValues
		{
			
			[System.ComponentModel.Description("No")]
			public const bool No = false;
			
			[System.ComponentModel.Description("Yes")]
			public const bool Yes = true;
		}
		#endregion
		
		#region 
	static
		public class islicensedValues
		{
			
			[System.ComponentModel.Description("No")]
			public const bool No = false;
			
			[System.ComponentModel.Description("Yes")]
			public const bool Yes = true;
		}
		#endregion
		
		#region 
	static
		public class issyncwithdirectoryValues
		{
			
			[System.ComponentModel.Description("No")]
			public const bool No = false;
			
			[System.ComponentModel.Description("Yes")]
			public const bool Yes = true;
		}
		#endregion
		
		#region 
	static
		public class msdyn_gdproptoutValues
		{
			
			[System.ComponentModel.Description("No")]
			public const bool No = false;
			
			[System.ComponentModel.Description("Yes")]
			public const bool Yes = true;
		}
		#endregion
		
		public enum outgoingemaildeliverymethodValues
		{
			
			[System.ComponentModel.Description("None")]
			None = 0,
			
			[System.ComponentModel.Description("Microsoft Dynamics 365 for Outlook")]
			MicrosoftDynamics365forOutlook = 1,
			
			[System.ComponentModel.Description("Server-Side Synchronization or Email Router")]
			ServerSideSynchronizationorEmailRouter = 2,
		}
		
		public enum preferredaddresscodeValues
		{
			
			[System.ComponentModel.Description("Mailing Address")]
			MailingAddress = 1,
			
			[System.ComponentModel.Description("Other Address")]
			OtherAddress = 2,
		}
		
		public enum preferredemailcodeValues
		{
			
			[System.ComponentModel.Description("Default Value")]
			DefaultValue = 1,
		}
		
		public enum preferredphonecodeValues
		{
			
			[System.ComponentModel.Description("Main Phone")]
			MainPhone = 1,
			
			[System.ComponentModel.Description("Other Phone")]
			OtherPhone = 2,
			
			[System.ComponentModel.Description("Home Phone")]
			HomePhone = 3,
			
			[System.ComponentModel.Description("Mobile Phone")]
			MobilePhone = 4,
		}
		
		#region 
	static
		public class setupuserValues
		{
			
			[System.ComponentModel.Description("No")]
			public const bool No = false;
			
			[System.ComponentModel.Description("Yes")]
			public const bool Yes = true;
		}
		#endregion
	}
	
	/// <summary>
	/// Collection of system users that routinely collaborate. Teams can be used to simplify record sharing and provide team members with common access to organization data when team members belong to different Business Units.
	/// </summary>
	public partial class Team
	{
		
		#region 
	static
		public class isdefaultValues
		{
			
			[System.ComponentModel.Description("No")]
			public const bool No = false;
			
			[System.ComponentModel.Description("Yes")]
			public const bool Yes = true;
		}
		#endregion
		
		#region 
	static
		public class systemmanagedValues
		{
			
			[System.ComponentModel.Description("No")]
			public const bool No = false;
			
			[System.ComponentModel.Description("Yes")]
			public const bool Yes = true;
		}
		#endregion
		
		public enum teamtypeValues
		{
			
			[System.ComponentModel.Description("Owner")]
			Owner = 0,
			
			[System.ComponentModel.Description("Access")]
			Access = 1,
			
			[System.ComponentModel.Description("AAD Security Group")]
			AADSecurityGroup = 2,
			
			[System.ComponentModel.Description("AAD Office Group")]
			AADOfficeGroup = 3,
		}
	}
	
	/// <summary>
	/// 
	/// </summary>
	public partial class TeamMembership
	{
	}
	
	/// <summary>
	/// Template for an email message that contains the standard attributes of an email message.
	/// </summary>
	public partial class Template
	{
		
		public enum componentstateValues
		{
			
			[System.ComponentModel.Description("Published")]
			Published = 0,
			
			[System.ComponentModel.Description("Unpublished")]
			Unpublished = 1,
			
			[System.ComponentModel.Description("Deleted")]
			Deleted = 2,
			
			[System.ComponentModel.Description("Deleted Unpublished")]
			DeletedUnpublished = 3,
		}
		
		#region 
	static
		public class ismanagedValues
		{
			
			[System.ComponentModel.Description("Unmanaged")]
			public const bool Unmanaged = false;
			
			[System.ComponentModel.Description("Managed")]
			public const bool Managed = true;
		}
		#endregion
		
		#region 
	static
		public class ispersonalValues
		{
			
			[System.ComponentModel.Description("Organization")]
			public const bool Organization = false;
			
			[System.ComponentModel.Description("Individual")]
			public const bool Individual = true;
		}
		#endregion
		
		#region 
	static
		public class isrecommendedValues
		{
			
			[System.ComponentModel.Description("No")]
			public const bool No = false;
			
			[System.ComponentModel.Description("Yes")]
			public const bool Yes = true;
		}
		#endregion
	}
	
	/// <summary>
	/// Time zone definition, including name and time zone code.
	/// </summary>
	public partial class TimeZoneDefinition
	{
	}
	
	/// <summary>
	/// Set of logical rules that define the steps necessary to automate a specific business process, task, or set of actions to be performed.
	/// </summary>
	public partial class Workflow
	{
		
		#region 
	static
		public class asyncautodeleteValues
		{
			
			[System.ComponentModel.Description("No")]
			public const bool No = false;
			
			[System.ComponentModel.Description("Yes")]
			public const bool Yes = true;
		}
		#endregion
		
		public enum businessprocesstypeValues
		{
			
			[System.ComponentModel.Description("Business Flow")]
			BusinessFlow = 0,
			
			[System.ComponentModel.Description("Task Flow")]
			TaskFlow = 1,
		}
		
		public enum categoryValues
		{
			
			[System.ComponentModel.Description("Workflow")]
			Workflow = 0,
			
			[System.ComponentModel.Description("Dialog")]
			Dialog = 1,
			
			[System.ComponentModel.Description("Business Rule")]
			BusinessRule = 2,
			
			[System.ComponentModel.Description("Action")]
			Action = 3,
			
			[System.ComponentModel.Description("Business Process Flow")]
			BusinessProcessFlow = 4,
			
			[System.ComponentModel.Description("Modern Flow")]
			ModernFlow = 5,
			
			[System.ComponentModel.Description("Reserved")]
			Reserved = 6,
		}
		
		public enum componentstateValues
		{
			
			[System.ComponentModel.Description("Published")]
			Published = 0,
			
			[System.ComponentModel.Description("Unpublished")]
			Unpublished = 1,
			
			[System.ComponentModel.Description("Deleted")]
			Deleted = 2,
			
			[System.ComponentModel.Description("Deleted Unpublished")]
			DeletedUnpublished = 3,
		}
		
		public enum createstageValues
		{
			
			[System.ComponentModel.Description("Pre-operation")]
			Preoperation = 20,
			
			[System.ComponentModel.Description("Post-operation")]
			Postoperation = 40,
		}
		
		public enum deletestageValues
		{
			
			[System.ComponentModel.Description("Pre-operation")]
			Preoperation = 20,
			
			[System.ComponentModel.Description("Post-operation")]
			Postoperation = 40,
		}
		
		#region 
	static
		public class iscrmuiworkflowValues
		{
			
			[System.ComponentModel.Description("No")]
			public const bool No = false;
			
			[System.ComponentModel.Description("Yes")]
			public const bool Yes = true;
		}
		#endregion
		
		#region 
	static
		public class ismanagedValues
		{
			
			[System.ComponentModel.Description("Unmanaged")]
			public const bool Unmanaged = false;
			
			[System.ComponentModel.Description("Managed")]
			public const bool Managed = true;
		}
		#endregion
		
		#region 
	static
		public class istransactedValues
		{
			
			[System.ComponentModel.Description("No")]
			public const bool No = false;
			
			[System.ComponentModel.Description("Yes")]
			public const bool Yes = true;
		}
		#endregion
		
		public enum modeValues
		{
			
			[System.ComponentModel.Description("Background")]
			Background = 0,
			
			[System.ComponentModel.Description("Real-time")]
			Realtime = 1,
		}
		
		#region 
	static
		public class ondemandValues
		{
			
			[System.ComponentModel.Description("No")]
			public const bool No = false;
			
			[System.ComponentModel.Description("Yes")]
			public const bool Yes = true;
		}
		#endregion
		
		public enum processtriggerscopeValues
		{
			
			[System.ComponentModel.Description("Form")]
			Form = 1,
			
			[System.ComponentModel.Description("Entity")]
			Entity = 2,
		}
		
		public enum runasValues
		{
			
			[System.ComponentModel.Description("Owner")]
			Owner = 0,
			
			[System.ComponentModel.Description("Calling User")]
			CallingUser = 1,
		}
		
		public enum scopeValues
		{
			
			[System.ComponentModel.Description("User")]
			User = 1,
			
			[System.ComponentModel.Description("Business Unit")]
			BusinessUnit = 2,
			
			[System.ComponentModel.Description("Parent: Child Business Units")]
			ParentChildBusinessUnits = 3,
			
			[System.ComponentModel.Description("Organization")]
			Organization = 4,
		}
		
		public enum statecodeValues
		{
			
			[System.ComponentModel.Description("Draft")]
			Draft = 0,
			
			[System.ComponentModel.Description("Activated")]
			Activated = 1,
		}
		
		public enum statuscodeValues
		{
			
			[System.ComponentModel.Description("Draft")]
			Draft = 1,
			
			[System.ComponentModel.Description("Activated")]
			Activated = 2,
		}
		
		#region 
	static
		public class subprocessValues
		{
			
			[System.ComponentModel.Description("No")]
			public const bool No = false;
			
			[System.ComponentModel.Description("Yes")]
			public const bool Yes = true;
		}
		#endregion
		
		#region 
	static
		public class syncworkflowlogonfailureValues
		{
			
			[System.ComponentModel.Description("No")]
			public const bool No = false;
			
			[System.ComponentModel.Description("Yes")]
			public const bool Yes = true;
		}
		#endregion
		
		#region 
	static
		public class triggeroncreateValues
		{
			
			[System.ComponentModel.Description("No")]
			public const bool No = false;
			
			[System.ComponentModel.Description("Yes")]
			public const bool Yes = true;
		}
		#endregion
		
		#region 
	static
		public class triggerondeleteValues
		{
			
			[System.ComponentModel.Description("No")]
			public const bool No = false;
			
			[System.ComponentModel.Description("Yes")]
			public const bool Yes = true;
		}
		#endregion
		
		public enum typeValues
		{
			
			[System.ComponentModel.Description("Definition")]
			Definition = 1,
			
			[System.ComponentModel.Description("Activation")]
			Activation = 2,
			
			[System.ComponentModel.Description("Template")]
			Template = 3,
		}
		
		public enum uiflowtypeValues
		{
			
			[System.ComponentModel.Description("Desktop")]
			Desktop = 0,
			
			[System.ComponentModel.Description("Selenium IDE")]
			SeleniumIDE = 1,
			
			[System.ComponentModel.Description("PowerShell")]
			PowerShell = 2,
		}
		
		public enum updatestageValues
		{
			
			[System.ComponentModel.Description("Pre-operation")]
			Preoperation = 20,
			
			[System.ComponentModel.Description("Post-operation")]
			Postoperation = 40,
		}
	}
}
