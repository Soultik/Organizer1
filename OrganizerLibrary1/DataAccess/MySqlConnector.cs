using Dapper;
using OrganizerLibrary.DataConnection;
using OrganizerLibrary.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using System.ComponentModel;
using System.Linq;

namespace OrganizerLibrary
{
    public class MySqlConnector : IDataConnection
    {
        #region Assignment
        /// <summary>
        /// Saves a new assignment to the database.
        /// </summary>
        /// <param name="model">The assignment information.</param>
        /// <returns>The assignment information, including the unique identifier.</returns>
        public AssignmentModel CreateAssignment(AssignmentModel model)
        {
            using (IDbConnection connection = new MySqlConnection(GlobalConfig.CnnString("OrganizerDB")))
            {
                // initializes dynamic parameters used for calling stored procedure
                var p = new DynamicParameters();
                p.Add("Comment_", model.Comment);
                p.Add("IsDone", model.IsDone);
                p.Add("DateFirst", model.DateAdded);
                p.Add("DateFinish", model.DateToFinish);
                // adds out type parameter
                p.Add("ID", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);
                // executes stored procedure
                connection.Execute("insert_assignment", p, commandType: CommandType.StoredProcedure);
                // gets back assigned ID for the new assignment in the database
                model.GeneralAssignmentId = p.Get<int>("ID");
                // returns model with the ID
                return model;
            }
        }
        /// <summary>
        /// Deletes a row from the database, that is being represented by parameter model.
        /// </summary>
        /// <param name="model">
        /// Used to pass Id of a row to delete to the database.
        /// </param>
        public void DeleteAssignment(AssignmentModel model)
        {
            using (IDbConnection connection = new MySqlConnection(GlobalConfig.CnnString("OrganizerDB")))
            {
                // initializes dynamic parameters used for calling stored procedure
                var p = new DynamicParameters();
                p.Add("Id", model.GeneralAssignmentId);
                // executes stored procedure
                connection.Execute("del_assignment", p, commandType: CommandType.StoredProcedure);
            }
        }
        /// <summary>
        /// Returns all unfulfilled assignments contained in the database.
        /// </summary>
        /// <returns>
        /// Assignments converted to binding list.
        /// </returns>
        public BindingList<AssignmentModel> GetAssignment_All()
        {            
            using (IDbConnection connection = new MySqlConnection(GlobalConfig.CnnString("OrganizerDB")))
            {   
                //creates a list to store selected values from the database
                List<AssignmentModel> Temp = new List<AssignmentModel>();
                //get assignmetns from the database
                Temp = connection.Query<AssignmentModel>("get_assignments").ToList();
                //creates sorted list using LINQ
                Temp = Temp.OrderByDescending(t => t.DateAdded).ToList();
                //creates binding list from the sorted list of database rows
                BindingList<AssignmentModel> DbAssignments = new BindingList<AssignmentModel>(Temp);
                //returns binding list 
                return DbAssignments;

            }
        }
        /// <summary>
        /// Updates assignment with the given Id in the database.
        /// </summary>
        /// <param name="Id">
        /// Database Id.
        /// </param>
        public void UpdateAssignment(AssignmentModel model)
        {
            using (IDbConnection connection = new MySqlConnection(GlobalConfig.CnnString("OrganizerDB")))
            {
                // initializes dynamic parameters used for calling stored procedure
                var p = new DynamicParameters();
                p.Add("Id", model.GeneralAssignmentId);
                p.Add("Comment_", model.Comment);
                p.Add("IsDone_", model.IsDone);
                p.Add("DateFirst", model.DateAdded);
                p.Add("DateFinish", model.DateToFinish);
                // executes stored procedure
                connection.Execute("update_assignment", p, commandType: CommandType.StoredProcedure);
                
            }
        }
        #endregion

        #region EventType

        public BindingList<EventTypeModel> GetEventType_All()
        {
            using (IDbConnection connection = new MySqlConnection(GlobalConfig.CnnString("OrganizerDB")))
            {
                //creates a list to store selected values from the database
                List<EventTypeModel> Temp = new List<EventTypeModel>();
                //get event types from the database
                Temp = connection.Query<EventTypeModel>("get_eventtype").ToList();
                //creates sorted list using LINQ
                Temp = Temp.OrderBy(t => t.EventTypeName).ToList();
                //creates binding list from the sorted list of database rows
                BindingList<EventTypeModel> DbEventTypes = new BindingList<EventTypeModel>(Temp);
                //returns binding list 
                return DbEventTypes;
            }
        }
        public void UpdateEventType(EventTypeModel model)
        {
            using (IDbConnection connection = new MySqlConnection(GlobalConfig.CnnString("OrganizerDB")))
            {
                // initializes dynamic parameters used for calling stored procedure
                var p = new DynamicParameters();
                p.Add("Id", model.EventTypeId);
                p.Add("Name_", model.EventTypeName);

                // executes stored procedure
                connection.Execute("update_eventtype", p, commandType: CommandType.StoredProcedure);

            }
        }
        public EventTypeModel CreateEventType(EventTypeModel model)
        {
            using (IDbConnection connection = new MySqlConnection(GlobalConfig.CnnString("OrganizerDB")))
            {
                var p = new DynamicParameters();
                p.Add("Name_", model.EventTypeName);
                p.Add("ID", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);
                connection.Execute("insert_eventtype", p, commandType: CommandType.StoredProcedure);
                model.EventTypeId = p.Get<int>("ID");
                return model;
            }
        }


        #endregion

        #region Events
        public BindingList<EventModel> GetEventsOfDay_All(DateTime day)
        {
            using (IDbConnection connection = new MySqlConnection(GlobalConfig.CnnString("OrganizerDB")))
            {
                var p = new DynamicParameters();
                p.Add("day_", day);
                //creates a list to store selected values from the database
                List<EventModel> Temp = new List<EventModel>();
                //get events from the database
                Temp = connection.Query<EventModel>("get_events_day_all", p, commandType: CommandType.StoredProcedure).ToList();
                //creates sorted list using LINQ
                Temp = Temp.OrderBy(t => t.StartTime).ToList();
                //creates binding list from the sorted list of database rows
                BindingList<EventModel> DbEvents = new BindingList<EventModel>(Temp);
                //returns binding list 
                return DbEvents;
            }
        }

        public void UpdateEvent(EventModel model)
        {
            using (IDbConnection connection = new MySqlConnection(GlobalConfig.CnnString("OrganizerDB")))
            {
                // initializes dynamic parameters used for calling stored procedure
                var p = new DynamicParameters();
                p.Add("Id_", model.EventId);
                p.Add("Comment_", model.Comment);
                p.Add("StartTime_", model.StartTime);
                p.Add("EndTime_", model.EndTime);
                p.Add("EventTypeId_", model.EventTypeId);

                // executes stored procedure
                connection.Execute("update_event", p, commandType: CommandType.StoredProcedure);
            }
        }

        public EventModel CreateEvent(EventModel model)
        {
            using (IDbConnection connection = new MySqlConnection(GlobalConfig.CnnString("OrganizerDB")))
            {
                // initializes dynamic parameters used for calling stored procedure
                var p = new DynamicParameters();
                p.Add("Comment_", model.Comment);
                p.Add("StartTime_", model.StartTime);
                p.Add("EndTime_", model.EndTime);
                p.Add("EventTypeId_", model.EventTypeId);
                p.Add("ID", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);
                // executes stored procedure
                connection.Execute("insert_event", p, commandType: CommandType.StoredProcedure);
                // saves the new id, generated by the database
                model.EventId = p.Get<int>("ID");
                // returns new model with new assigned id
                return model;
            }
        }

        public void DeleteEvent(EventModel model)
        {
            using (IDbConnection connection = new MySqlConnection(GlobalConfig.CnnString("OrganizerDB")))
            {
                // initializes dynamic parameters used for calling stored procedure
                var p = new DynamicParameters();
                p.Add("Id_", model.EventId);
                // executes stored procedure
                connection.Execute("del_event", p, commandType: CommandType.StoredProcedure);
            }
        }

        #endregion

        #region TemplateDay

        public BindingList<EventModel> GetTemplateEvents(string day)
        {            
            using (IDbConnection connection = new MySqlConnection(GlobalConfig.CnnString("OrganizerDB")))
            {
                var p = new DynamicParameters();
                p.Add("day_", day);
                //creates a list to store selected events from the database
                List<EventModel> temp = new List<EventModel>();
                //get events from the database
                temp = connection.Query<EventModel>("get_template_events", p, commandType: CommandType.StoredProcedure).ToList();
                //creates sorted list using LINQ
                temp = temp.OrderBy(t => t.StartTime).ToList();
                //creates binding list from the sorted list of database rows
                BindingList<EventModel> DbEvents = new BindingList<EventModel>(temp);
                //returns binding list 
                return DbEvents;
            }
        }

        public EventModel CreateTemplateEvent(EventModel model, int day)
        {
            using (IDbConnection connection = new MySqlConnection(GlobalConfig.CnnString("OrganizerDB")))
            {
                // initializes dynamic parameters used for calling stored procedure
                var p = new DynamicParameters();
                p.Add("TDayId_", day);
                p.Add("StartTime_", model.StartTime);
                p.Add("EndTime_", model.EndTime);
                p.Add("EventTypeId_", model.EventTypeId);
                p.Add("ID", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);
                // executes stored procedure
                connection.Execute("insert_template_event", p, commandType: CommandType.StoredProcedure);
                // saves the new id, generated by the database
                model.EventId = p.Get<int>("ID");
                // returns new model with new assigned id
                return model;
            }
        }

        public void UpdateTemplateEvent(EventModel model)
        {
            using (IDbConnection connection = new MySqlConnection(GlobalConfig.CnnString("OrganizerDB")))
            {
                // initializes dynamic parameters used for calling stored procedure
                var p = new DynamicParameters();
                p.Add("Id_", model.EventId);
                p.Add("StartTime_", model.StartTime);
                p.Add("EndTime_", model.EndTime);
                p.Add("EventTypeId_", model.EventTypeId);

                // executes stored procedure
                connection.Execute("update_template_event", p, commandType: CommandType.StoredProcedure);
            }
        }

        public void DeleteTemplateEvent(EventModel model)
        {
            using (IDbConnection connection = new MySqlConnection(GlobalConfig.CnnString("OrganizerDB")))
            {
                // initializes dynamic parameters used for calling stored procedure
                var p = new DynamicParameters();
                p.Add("Id_", model.EventId);
                // executes stored procedure
                connection.Execute("del_template_event", p, commandType: CommandType.StoredProcedure);
            }
        }


        #endregion

        public void InitializeBasicSchedule(List<EventModel> models, DateTime startDate, DateTime endDate, string weekday)
        {
            // value used to indicate if we're adding events to a weekend or a weekday
            // passing 5 to the stored procedure if it's a weekday and 7 if it's a weekend
            int day = 5;
            if (weekday == "Weekend") day = 7;

            using (IDbConnection connection = new MySqlConnection(GlobalConfig.CnnString("OrganizerDB")))
            {
                int i = 0;
                foreach (EventModel ev in models)
                { 
                    // initializes dynamic parameters used for calling stored procedure
                    var p = new DynamicParameters();
                    p.Add("StartTime_", models[i].StartTime);
                    p.Add("EndTime_", models[i].EndTime);
                    p.Add("EventTypeId_", models[i].EventTypeId);
                    p.Add("StartDate_", startDate);
                    p.Add("EndDate_", endDate);
                    p.Add("DayType_", day);
                    // executes stored procedure
                    connection.Execute("insert_event_series", p, commandType: CommandType.StoredProcedure);
                    i++;

                }
            }
        }
    }
}
