using System;
using System.Collections.Generic;
using GameSparks.Core;
using GameSparks.Api.Requests;
using GameSparks.Api.Responses;

//THIS FILE IS AUTO GENERATED, DO NOT MODIFY!!
//THIS FILE IS AUTO GENERATED, DO NOT MODIFY!!
//THIS FILE IS AUTO GENERATED, DO NOT MODIFY!!

namespace GameSparks.Api.Requests{
	public class LogEventRequest_AddDoc : GSTypedRequest<LogEventRequest_AddDoc, LogEventResponse>
	{
	
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new LogEventResponse (response);
		}
		
		public LogEventRequest_AddDoc() : base("LogEventRequest"){
			request.AddString("eventKey", "AddDoc");
		}
		
		public LogEventRequest_AddDoc Set_Active( string value )
		{
			request.AddString("Active", value);
			return this;
		}
	}
	
	public class LogChallengeEventRequest_AddDoc : GSTypedRequest<LogChallengeEventRequest_AddDoc, LogChallengeEventResponse>
	{
		public LogChallengeEventRequest_AddDoc() : base("LogChallengeEventRequest"){
			request.AddString("eventKey", "AddDoc");
		}
		
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new LogChallengeEventResponse (response);
		}
		
		/// <summary>
		/// The challenge ID instance to target
		/// </summary>
		public LogChallengeEventRequest_AddDoc SetChallengeInstanceId( String challengeInstanceId )
		{
			request.AddString("challengeInstanceId", challengeInstanceId);
			return this;
		}
		public LogChallengeEventRequest_AddDoc Set_Active( string value )
		{
			request.AddString("Active", value);
			return this;
		}
	}
	
	public class LogEventRequest_CreatePP : GSTypedRequest<LogEventRequest_CreatePP, LogEventResponse>
	{
	
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new LogEventResponse (response);
		}
		
		public LogEventRequest_CreatePP() : base("LogEventRequest"){
			request.AddString("eventKey", "CreatePP");
		}
		
		public LogEventRequest_CreatePP Set_Email( string value )
		{
			request.AddString("Email", value);
			return this;
		}
	}
	
	public class LogChallengeEventRequest_CreatePP : GSTypedRequest<LogChallengeEventRequest_CreatePP, LogChallengeEventResponse>
	{
		public LogChallengeEventRequest_CreatePP() : base("LogChallengeEventRequest"){
			request.AddString("eventKey", "CreatePP");
		}
		
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new LogChallengeEventResponse (response);
		}
		
		/// <summary>
		/// The challenge ID instance to target
		/// </summary>
		public LogChallengeEventRequest_CreatePP SetChallengeInstanceId( String challengeInstanceId )
		{
			request.AddString("challengeInstanceId", challengeInstanceId);
			return this;
		}
		public LogChallengeEventRequest_CreatePP Set_Email( string value )
		{
			request.AddString("Email", value);
			return this;
		}
	}
	
	public class LogEventRequest_EmailValidation : GSTypedRequest<LogEventRequest_EmailValidation, LogEventResponse>
	{
	
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new LogEventResponse (response);
		}
		
		public LogEventRequest_EmailValidation() : base("LogEventRequest"){
			request.AddString("eventKey", "EmailValidation");
		}
		
		public LogEventRequest_EmailValidation Set_Email( string value )
		{
			request.AddString("Email", value);
			return this;
		}
	}
	
	public class LogChallengeEventRequest_EmailValidation : GSTypedRequest<LogChallengeEventRequest_EmailValidation, LogChallengeEventResponse>
	{
		public LogChallengeEventRequest_EmailValidation() : base("LogChallengeEventRequest"){
			request.AddString("eventKey", "EmailValidation");
		}
		
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new LogChallengeEventResponse (response);
		}
		
		/// <summary>
		/// The challenge ID instance to target
		/// </summary>
		public LogChallengeEventRequest_EmailValidation SetChallengeInstanceId( String challengeInstanceId )
		{
			request.AddString("challengeInstanceId", challengeInstanceId);
			return this;
		}
		public LogChallengeEventRequest_EmailValidation Set_Email( string value )
		{
			request.AddString("Email", value);
			return this;
		}
	}
	
	public class LogEventRequest_GetDeviceSpecs : GSTypedRequest<LogEventRequest_GetDeviceSpecs, LogEventResponse>
	{
	
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new LogEventResponse (response);
		}
		
		public LogEventRequest_GetDeviceSpecs() : base("LogEventRequest"){
			request.AddString("eventKey", "GetDeviceSpecs");
		}
		
		public LogEventRequest_GetDeviceSpecs Set_ID( string value )
		{
			request.AddString("ID", value);
			return this;
		}
	}
	
	public class LogChallengeEventRequest_GetDeviceSpecs : GSTypedRequest<LogChallengeEventRequest_GetDeviceSpecs, LogChallengeEventResponse>
	{
		public LogChallengeEventRequest_GetDeviceSpecs() : base("LogChallengeEventRequest"){
			request.AddString("eventKey", "GetDeviceSpecs");
		}
		
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new LogChallengeEventResponse (response);
		}
		
		/// <summary>
		/// The challenge ID instance to target
		/// </summary>
		public LogChallengeEventRequest_GetDeviceSpecs SetChallengeInstanceId( String challengeInstanceId )
		{
			request.AddString("challengeInstanceId", challengeInstanceId);
			return this;
		}
		public LogChallengeEventRequest_GetDeviceSpecs Set_ID( string value )
		{
			request.AddString("ID", value);
			return this;
		}
	}
	
	public class LogEventRequest_GetPersonalProfile : GSTypedRequest<LogEventRequest_GetPersonalProfile, LogEventResponse>
	{
	
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new LogEventResponse (response);
		}
		
		public LogEventRequest_GetPersonalProfile() : base("LogEventRequest"){
			request.AddString("eventKey", "GetPersonalProfile");
		}
	}
	
	public class LogChallengeEventRequest_GetPersonalProfile : GSTypedRequest<LogChallengeEventRequest_GetPersonalProfile, LogChallengeEventResponse>
	{
		public LogChallengeEventRequest_GetPersonalProfile() : base("LogChallengeEventRequest"){
			request.AddString("eventKey", "GetPersonalProfile");
		}
		
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new LogChallengeEventResponse (response);
		}
		
		/// <summary>
		/// The challenge ID instance to target
		/// </summary>
		public LogChallengeEventRequest_GetPersonalProfile SetChallengeInstanceId( String challengeInstanceId )
		{
			request.AddString("challengeInstanceId", challengeInstanceId);
			return this;
		}
	}
	
	public class LogEventRequest_InitTestCollection : GSTypedRequest<LogEventRequest_InitTestCollection, LogEventResponse>
	{
	
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new LogEventResponse (response);
		}
		
		public LogEventRequest_InitTestCollection() : base("LogEventRequest"){
			request.AddString("eventKey", "InitTestCollection");
		}
	}
	
	public class LogChallengeEventRequest_InitTestCollection : GSTypedRequest<LogChallengeEventRequest_InitTestCollection, LogChallengeEventResponse>
	{
		public LogChallengeEventRequest_InitTestCollection() : base("LogChallengeEventRequest"){
			request.AddString("eventKey", "InitTestCollection");
		}
		
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new LogChallengeEventResponse (response);
		}
		
		/// <summary>
		/// The challenge ID instance to target
		/// </summary>
		public LogChallengeEventRequest_InitTestCollection SetChallengeInstanceId( String challengeInstanceId )
		{
			request.AddString("challengeInstanceId", challengeInstanceId);
			return this;
		}
	}
	
	public class LogEventRequest_InitDevicesCollection : GSTypedRequest<LogEventRequest_InitDevicesCollection, LogEventResponse>
	{
	
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new LogEventResponse (response);
		}
		
		public LogEventRequest_InitDevicesCollection() : base("LogEventRequest"){
			request.AddString("eventKey", "InitDevicesCollection");
		}
	}
	
	public class LogChallengeEventRequest_InitDevicesCollection : GSTypedRequest<LogChallengeEventRequest_InitDevicesCollection, LogChallengeEventResponse>
	{
		public LogChallengeEventRequest_InitDevicesCollection() : base("LogChallengeEventRequest"){
			request.AddString("eventKey", "InitDevicesCollection");
		}
		
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new LogChallengeEventResponse (response);
		}
		
		/// <summary>
		/// The challenge ID instance to target
		/// </summary>
		public LogChallengeEventRequest_InitDevicesCollection SetChallengeInstanceId( String challengeInstanceId )
		{
			request.AddString("challengeInstanceId", challengeInstanceId);
			return this;
		}
	}
	
	public class LogEventRequest_InitPersonalProfile : GSTypedRequest<LogEventRequest_InitPersonalProfile, LogEventResponse>
	{
	
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new LogEventResponse (response);
		}
		
		public LogEventRequest_InitPersonalProfile() : base("LogEventRequest"){
			request.AddString("eventKey", "InitPersonalProfile");
		}
	}
	
	public class LogChallengeEventRequest_InitPersonalProfile : GSTypedRequest<LogChallengeEventRequest_InitPersonalProfile, LogChallengeEventResponse>
	{
		public LogChallengeEventRequest_InitPersonalProfile() : base("LogChallengeEventRequest"){
			request.AddString("eventKey", "InitPersonalProfile");
		}
		
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new LogChallengeEventResponse (response);
		}
		
		/// <summary>
		/// The challenge ID instance to target
		/// </summary>
		public LogChallengeEventRequest_InitPersonalProfile SetChallengeInstanceId( String challengeInstanceId )
		{
			request.AddString("challengeInstanceId", challengeInstanceId);
			return this;
		}
	}
	
	public class LogEventRequest_InsertTestCollection : GSTypedRequest<LogEventRequest_InsertTestCollection, LogEventResponse>
	{
	
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new LogEventResponse (response);
		}
		
		public LogEventRequest_InsertTestCollection() : base("LogEventRequest"){
			request.AddString("eventKey", "InsertTestCollection");
		}
		
		public LogEventRequest_InsertTestCollection Set_ID( string value )
		{
			request.AddString("ID", value);
			return this;
		}
		
		public LogEventRequest_InsertTestCollection Set_Info( string value )
		{
			request.AddString("Info", value);
			return this;
		}
	}
	
	public class LogChallengeEventRequest_InsertTestCollection : GSTypedRequest<LogChallengeEventRequest_InsertTestCollection, LogChallengeEventResponse>
	{
		public LogChallengeEventRequest_InsertTestCollection() : base("LogChallengeEventRequest"){
			request.AddString("eventKey", "InsertTestCollection");
		}
		
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new LogChallengeEventResponse (response);
		}
		
		/// <summary>
		/// The challenge ID instance to target
		/// </summary>
		public LogChallengeEventRequest_InsertTestCollection SetChallengeInstanceId( String challengeInstanceId )
		{
			request.AddString("challengeInstanceId", challengeInstanceId);
			return this;
		}
		public LogChallengeEventRequest_InsertTestCollection Set_ID( string value )
		{
			request.AddString("ID", value);
			return this;
		}
		public LogChallengeEventRequest_InsertTestCollection Set_Info( string value )
		{
			request.AddString("Info", value);
			return this;
		}
	}
	
	public class LogEventRequest_LoginDevice : GSTypedRequest<LogEventRequest_LoginDevice, LogEventResponse>
	{
	
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new LogEventResponse (response);
		}
		
		public LogEventRequest_LoginDevice() : base("LogEventRequest"){
			request.AddString("eventKey", "LoginDevice");
		}
		
		public LogEventRequest_LoginDevice Set_ID( string value )
		{
			request.AddString("ID", value);
			return this;
		}
	}
	
	public class LogChallengeEventRequest_LoginDevice : GSTypedRequest<LogChallengeEventRequest_LoginDevice, LogChallengeEventResponse>
	{
		public LogChallengeEventRequest_LoginDevice() : base("LogChallengeEventRequest"){
			request.AddString("eventKey", "LoginDevice");
		}
		
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new LogChallengeEventResponse (response);
		}
		
		/// <summary>
		/// The challenge ID instance to target
		/// </summary>
		public LogChallengeEventRequest_LoginDevice SetChallengeInstanceId( String challengeInstanceId )
		{
			request.AddString("challengeInstanceId", challengeInstanceId);
			return this;
		}
		public LogChallengeEventRequest_LoginDevice Set_ID( string value )
		{
			request.AddString("ID", value);
			return this;
		}
	}
	
	public class LogEventRequest_RegisterDevice : GSTypedRequest<LogEventRequest_RegisterDevice, LogEventResponse>
	{
	
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new LogEventResponse (response);
		}
		
		public LogEventRequest_RegisterDevice() : base("LogEventRequest"){
			request.AddString("eventKey", "RegisterDevice");
		}
		
		public LogEventRequest_RegisterDevice Set_Model( string value )
		{
			request.AddString("Model", value);
			return this;
		}
		
		public LogEventRequest_RegisterDevice Set_Name( string value )
		{
			request.AddString("Name", value);
			return this;
		}
		
		public LogEventRequest_RegisterDevice Set_Type( string value )
		{
			request.AddString("Type", value);
			return this;
		}
		
		public LogEventRequest_RegisterDevice Set_Platform( string value )
		{
			request.AddString("Platform", value);
			return this;
		}
		
		public LogEventRequest_RegisterDevice Set_ID( string value )
		{
			request.AddString("ID", value);
			return this;
		}
		
		public LogEventRequest_RegisterDevice Set_Processor( string value )
		{
			request.AddString("Processor", value);
			return this;
		}
		
		public LogEventRequest_RegisterDevice Set_Graphics( string value )
		{
			request.AddString("Graphics", value);
			return this;
		}
	}
	
	public class LogChallengeEventRequest_RegisterDevice : GSTypedRequest<LogChallengeEventRequest_RegisterDevice, LogChallengeEventResponse>
	{
		public LogChallengeEventRequest_RegisterDevice() : base("LogChallengeEventRequest"){
			request.AddString("eventKey", "RegisterDevice");
		}
		
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new LogChallengeEventResponse (response);
		}
		
		/// <summary>
		/// The challenge ID instance to target
		/// </summary>
		public LogChallengeEventRequest_RegisterDevice SetChallengeInstanceId( String challengeInstanceId )
		{
			request.AddString("challengeInstanceId", challengeInstanceId);
			return this;
		}
		public LogChallengeEventRequest_RegisterDevice Set_Model( string value )
		{
			request.AddString("Model", value);
			return this;
		}
		public LogChallengeEventRequest_RegisterDevice Set_Name( string value )
		{
			request.AddString("Name", value);
			return this;
		}
		public LogChallengeEventRequest_RegisterDevice Set_Type( string value )
		{
			request.AddString("Type", value);
			return this;
		}
		public LogChallengeEventRequest_RegisterDevice Set_Platform( string value )
		{
			request.AddString("Platform", value);
			return this;
		}
		public LogChallengeEventRequest_RegisterDevice Set_ID( string value )
		{
			request.AddString("ID", value);
			return this;
		}
		public LogChallengeEventRequest_RegisterDevice Set_Processor( string value )
		{
			request.AddString("Processor", value);
			return this;
		}
		public LogChallengeEventRequest_RegisterDevice Set_Graphics( string value )
		{
			request.AddString("Graphics", value);
			return this;
		}
	}
	
	public class LogEventRequest_UsernameCheck : GSTypedRequest<LogEventRequest_UsernameCheck, LogEventResponse>
	{
	
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new LogEventResponse (response);
		}
		
		public LogEventRequest_UsernameCheck() : base("LogEventRequest"){
			request.AddString("eventKey", "UsernameCheck");
		}
		
		public LogEventRequest_UsernameCheck Set_Username( string value )
		{
			request.AddString("Username", value);
			return this;
		}
	}
	
	public class LogChallengeEventRequest_UsernameCheck : GSTypedRequest<LogChallengeEventRequest_UsernameCheck, LogChallengeEventResponse>
	{
		public LogChallengeEventRequest_UsernameCheck() : base("LogChallengeEventRequest"){
			request.AddString("eventKey", "UsernameCheck");
		}
		
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new LogChallengeEventResponse (response);
		}
		
		/// <summary>
		/// The challenge ID instance to target
		/// </summary>
		public LogChallengeEventRequest_UsernameCheck SetChallengeInstanceId( String challengeInstanceId )
		{
			request.AddString("challengeInstanceId", challengeInstanceId);
			return this;
		}
		public LogChallengeEventRequest_UsernameCheck Set_Username( string value )
		{
			request.AddString("Username", value);
			return this;
		}
	}
	
}
	

namespace GameSparks.Api.Messages {


}
