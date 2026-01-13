

namespace ANC.Domain.Constant
{

	public class ApplicationConstants
	{
		public const string KEYID_EXISTED = "KeyId {0} đã tồn tại.";
		public const string KeyId = "KeyId";
		public const string DUPLICATE = "Symtem_id is duplicated";
		public const int BREAK_TIME = 1;
		public const int WORKINGSTEP = 1;
	}

	public class ResponseCodeConstants
	{
		public const string NOT_FOUND = "Not found!";
		public const string SUCCESS = "Success!";
		public const string FAILED = "Failed!";
		public const string EXISTED = "Existed!";
		public const string DUPLICATE = "Duplicate!";
		public const string INTERNAL_SERVER_ERROR = "INTERNAL_SERVER_ERROR";
		public const string INVALID_INPUT = "Invalid input!";
		public const string UNAUTHORIZED = "Unauthorized!";
		public const string FORBIDDEN = "Forbidden!";
		public const string BADREQUEST = "Bad request!";
	}
	public enum UserRole
	{
		Admin,
		Manager,
		Employee,
		HR
	}

	public enum Gender
	{
		Male,
		Female,
		Other
	}

	public enum Position
	{
		Manager,
		Developer,
		Designer,
		HR,
		Accountant,
		Other
	}

	public enum EmployeeStatus
	{
		Active,
		Inactive,
		OnLeave,
		Terminated
	}

	public enum DeviceType
	{
		Fingerprint,
		FaceRecognition,
		CardReader,
		Mobile
	}

	public enum DeviceStatus
	{
		Active,
		Inactive,
		Maintenance,
		Error
	}

	public enum ScheduleStatus
	{
		Pending,
		Confirmed,
		Cancelled,
		Completed
	}

	public enum CheckType
	{
		CheckIn,
		CheckOut
	}

	public enum RequestType
	{
		Leave,
		LateArrival,
		EarlyDeparture,
		Overtime,
		ForgotCheckIn,
		ForgotCheckOut
	}

	public enum RequestStatus
	{
		Pending,
		Approved,
		Rejected,
		Cancelled
	}

	public enum ApprovalStatus
	{
		Pending,
		Approved,
		Rejected
	}

	public enum CertificateType
	{
		Degree,
		Certificate,
		License,
		Other
	}

	public enum CertificateStatus
	{
		Valid,
		Expired,
		Revoked
	}

	public enum ContractType
	{
		Permanent,
		Fixed,
		Probation,
		Internship
	}

	public enum ContractStatus
	{
		Active,
		Expired,
		Terminated,
		Pending
	}

	public enum AuditAction
	{
		Create,
		Update,
		Delete,
		Login,
		Logout
	}
}

