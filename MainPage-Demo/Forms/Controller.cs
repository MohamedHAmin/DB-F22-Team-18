using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace MainPage_Demo.Forms
{
    public class Controller
    {
        DBManager dbMan;
        public Controller()
        {
            dbMan = new DBManager();
        }


        public void TerminateConnection()
        {
            dbMan.CloseConnection();
        }
        //public int InsertCustomer(string ssn, string name, string mobn)
        //{
        //    string query = "insert into Customer values('" + ssn + "','" + name + "','" + mobn + "');";
        //    return dbMan.ExecuteNonQuery(query);
        //}

        //--------------------------------------------------------------------------//
        public DataTable SelectSystemUser(string Username, string Password)
        {
            string query = "SELECT * FROM SystemUser WHERE Username = '" + Username + "' AND Password = '" + Password + "'";
            return dbMan.ExecuteReader(query);
        }
        public int UpdateSystemUser(string username, string newPassword)
        {
            string query = "UPDATE SystemUser SET Password='" + newPassword + "' WHERE Username ='" + username + "';";
            return dbMan.ExecuteNonQuery(query);
        }
        public DataTable SelectCustomer(string Phone)
        {
            string query = "SELECT * FROM Customer WHERE Phone = '" + Phone + "'";
            return dbMan.ExecuteReader(query);
        }
        public int InsertCustomer(string firstname, string lastname, string phone)
        {
            string query = "INSERT INTO Customer (FirstName, LastName, Phone) Values ('" + firstname + "', '" + lastname + "', '" + phone + "')";
            return dbMan.ExecuteNonQuery(query);
        }
        public DataTable SelectWorker(string ssn)
        {
            string query = "SELECT * FROM Worker WHERE SSN = '" + ssn + "'";
            return dbMan.ExecuteReader(query);
        }
        public int InsertWorker(string firstname, string lastname, string ssn, string salary, string phone)
        {
            string query = "INSERT INTO Worker Values ('" + firstname  +" ', ' " + lastname + " ', '" + ssn + "', '" + salary + "', '" + phone + "')";
            return dbMan.ExecuteNonQuery(query);
        }
        public DataTable SelectUser(string Username)
        {
            string query = "SELECT * FROM SystemUser WHERE Username = '" + Username + "'";
            return dbMan.ExecuteReader(query);
        }
        public int InsertSystemUser(string username, string firstname, string lastname, string phone, string ssn, string salary)
        {
            string query = "INSERT INTO SystemUser (Username, FirstName, LastName, Phone, SSN, Salary) Values ('" + username + " ', '" + firstname + " ', ' " + lastname + " ', '" + phone + " ', '" + ssn + "', '" + salary + "')";
            return dbMan.ExecuteNonQuery(query);
        }
        public DataTable SelectCustomerOffer(int numOfOrders)
        {
            string query = "SELECT MAX(Discount) FROM Offers WHERE NumberOfOrders <= " + numOfOrders + ";";
            return dbMan.ExecuteReader(query);
        }
        public DataTable SelectAllServices()
        {
            string query = "SELECT * FROM Services";
            return dbMan.ExecuteReader(query);
        }
        public DataTable SelectServices(string ServiceName)
        {
            string query = "SELECT * FROM Services WHERE ServiceName = '"+ ServiceName +"'";
            return dbMan.ExecuteReader(query);
        }
        public int UpdateNumOfOrders(int numberOfOrders, int id)
        {
            string query = "UPDATE Customer SET NumberOfOrders=" + numberOfOrders + " WHERE ID =" + id + ";";
            return dbMan.ExecuteNonQuery(query);
        }
        public DataTable SelectAllDevicesNotInMaintenance()
        {
            string query = "SELECT * FROM Devices WHERE InMaintenance = 0";
            return dbMan.ExecuteReader(query);
        }
        public DataTable SelectDevices(int id)
        {
            string query = "SELECT * FROM Devices WHERE ID = " + id;
            return dbMan.ExecuteReader(query);
        }
        public DataTable SelectMaintenanceInfo(string name)
        {
            string query = "SELECT * FROM Maintenance WHERE DeviceName = '" + name + "'";
            return dbMan.ExecuteReader(query);
        }
        public int UpdateDeviceMaintenance(int id)
        {
            string query = "UPDATE Devices SET InMaintenance=" + 1 + " WHERE ID =" + id + ";";
            return dbMan.ExecuteNonQuery(query);
        }
        public int InsertLogs(string type, string name, int id, int cost, string tellername, string company, string companyContanct, string date)
        {
            string query = "INSERT INTO Logs Values ('" + type + "', '" + name + "', " + id + ", " + cost + ", '" + tellername + "', '" + company + "', '" + companyContanct + "', '" + date + "')";
            return dbMan.ExecuteNonQuery(query);
        }
        public DataTable SelectAllLogs()
        {
            string query = "SELECT * FROM Logs";
            return dbMan.ExecuteReader(query);
        }
        public DataTable SelectWeekLogs()
        {
            string query = "SELECT * FROM Logs WHERE Date >='" + DateTime.Today.AddDays(-7) + "'";
            return dbMan.ExecuteReader(query);
        }
        public DataTable SelectMonthLogs()
        {
            string query = "SELECT * FROM Logs WHERE Date >='"+ DateTime.Today.AddDays(-30) +"'";
            return dbMan.ExecuteReader(query);
        }
        public DataTable SelectAllWorkers()
        {
            string query = "SELECT * FROM Worker";
            return dbMan.ExecuteReader(query);
        }
        public DataTable SelectWorkerSchedule(string ssn)
        {
            string query = "SELECT * FROM Schedule WHERE WorkerSSN ='" + ssn + "'";
            return dbMan.ExecuteReader(query);
        }
        public DataTable SelectMaxSchedule(string ssn)
        {
            string query = "SELECT * FROM Schedule WHERE FinishTime = (SELECT Min(FinishTime) FROM Schedule) AND WorkerSSN ='"+ ssn +"'";
            return dbMan.ExecuteReader(query);
        }
        public int InsertSchedule(string CName, int orderID, string ssn, string starttime, string endtime)
        {
            string query = "INSERT INTO Schedule Values ('" + CName + "',"+ orderID +", '" + ssn + "', '"+ starttime +"', '"+ endtime +"')";
            return dbMan.ExecuteNonQuery(query);
        }
        public int InsertOrder(int cost, string date, string TName)
        {
            string query = "INSERT INTO [Order] (Cost, Date, TellerName) Values (" + cost + ", '" + date + "', '" + TName + "')";
            return dbMan.ExecuteNonQuery(query);
        }
        public DataTable SelectOrderID()
        {
            string query = "SELECT MAX(ID) FROM [Order]";
            return dbMan.ExecuteReader(query);
        }
        public DataTable SelectProudctsInService(string serviceName)
        {
            string query = "SELECT * FROM UsedProductsInService WHERE ServiceName ='"+ serviceName + "'";
            return dbMan.ExecuteReader(query);
        }
        public DataTable SelectProudct(string productName)
        {
            string query = "SELECT * FROM Inventory WHERE ProductName ='" + productName + "'";
            return dbMan.ExecuteReader(query);
        }
        public DataTable SelectALLSchedule()
        {
            string query = "SELECT * FROM Schedule";
            return dbMan.ExecuteReader(query);
        }
        public int DeleteSchedule(int orderID)
        {
            string query = "DELETE FROM Schedule WHERE OrderID=" + orderID;
            return dbMan.ExecuteNonQuery(query);
        }
        //--------------------------------------------------------------------------//
        public DataTable selectWorkersInfo()
        {
            string query = "select * from worker";
            return dbMan.ExecuteReader(query);
        }
        public DataTable selectservicesInfo()
        {
            string query = "select * from services";
            return dbMan.ExecuteReader(query);
        }
        public DataTable selectservicesInfo(string servicename)
        {
            string query = "select * from services where servicename='" + servicename + "'";
            return dbMan.ExecuteReader(query);
        }
        public int countworkers()
        {
            /* string query = "select COUNT(*) from Worker  ";
             return (int)dbMan.ExecuteScalar(query);*/
            string StoredProcedureName = StoredProcedures.CountWorkers;
            return (int)dbMan.ExecuteScalar_S(StoredProcedureName, null);

        }
        public int selectsalarywithssn(long ssn)
        {
            string query = "select salary from worker where ssn=" + ssn;
            return (int)dbMan.ExecuteNonQuery(query);

        }
        public long selectphonenowithssn(long ssn)
        {
            string query = "select phone from worker where ssn=" + ssn;
            return Int64.Parse(dbMan.ExecuteScalar(query).ToString());

        }
        public int update_salary(long ssn, int salary)
        {
            string query = "update worker set salary='" + salary + "' where ssn='" + ssn + "'";

            return dbMan.ExecuteNonQuery(query);
        }
        public int update_phoneno(long ssn, long phoneno)
        {
            string query = "update worker set phone='" + phoneno + "' where ssn='" + ssn + "'";

            return dbMan.ExecuteNonQuery(query);
        }
        public int insert_worker(long ssn, long phoneno, string first_name, string last_name, int salary)
        {
            string query = "insert into worker (ssn,phone,firstName,lastname,salary) values (" + ssn + "," + phoneno + ",'" + first_name + "','" + last_name + "'," + salary + ")";

            return dbMan.ExecuteNonQuery(query);
        }

        public int delete_worker(long ssn)

        {
            string query = "delete from worker where ssn='" + ssn + "'";

            return dbMan.ExecuteNonQuery(query);
        }
        public int insert_service(int discount, int price, int duration, string service_name)
        {
            /*string query = "insert into services (Discount,price,ServiceDuration,servicename) values (" + discount + "," + price + "," + duration + ",'" + service_name + "')";
            return dbMan.ExecuteNonQuery(query);*/
            string StoredProcedureName = StoredProcedures.InsertService;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@discount", discount);
            Parameters.Add("@ServiceName", service_name);
            Parameters.Add("@duration", duration);
            Parameters.Add("@price", price);
            return dbMan.ExecuteNonQuery_S(StoredProcedureName, Parameters);

        }
        public int update_discount(string servicename, int discount)
        {
            /*string query = "update services set discount=" + discount + " where servicename='" + servicename + "'";
            return dbMan.ExecuteNonQuery(query);*/
            string StoredProcedureName = StoredProcedures.UpdateDiscount;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@ServiceName", servicename);
            Parameters.Add("@discount", discount);
            return dbMan.ExecuteNonQuery_S(StoredProcedureName, Parameters);
        }
        public int update_price(string servicename, int price)
        {
            /*string query = "update services set price=" + price + " where servicename='" + servicename + "'";
            return dbMan.ExecuteNonQuery(query);*/
            string StoredProcedureName = StoredProcedures.UpdatePrice;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@ServiceName", servicename);
            Parameters.Add("@price", price);
            return dbMan.ExecuteNonQuery_S(StoredProcedureName, Parameters);
        }
        public int update_duration(string servicename, int duration)
        {
            /*string query = "update services set serviceduration=" + duration + " where servicename='" + servicename + "'";
            return dbMan.ExecuteNonQuery(query);*/
            string StoredProcedureName = StoredProcedures.UpdateDuration;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@ServiceName", servicename);
            Parameters.Add("@duration", duration);
            return dbMan.ExecuteNonQuery_S(StoredProcedureName, Parameters);
        }
        public int delete_service(string servicename)
        {
            /*string query = "delete from services where servicename='" + servicename + "'";
            return dbMan.ExecuteNonQuery(query);*/
            string StoredProcedureName = StoredProcedures.DeleteService;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@ServiceName", servicename);
            return dbMan.ExecuteNonQuery_S(StoredProcedureName, Parameters);
        }
        public DataTable selectdevicesInfo()
        {
            /*string query = "select * from devices";
            return dbMan.ExecuteReader(query);*/
            string StoredProcedureName = StoredProcedures.SelectDevicesInfo;
            return dbMan.ExecuteReader_S(StoredProcedureName, null);
        }
        public int delete_device(int deviceid)

        {
            /*string query = "delete from devices where id='" + deviceid + "'";
            return dbMan.ExecuteNonQuery(query);*/
            string StoredProcedureName = StoredProcedures.DeleteDevice;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@DeviceId", deviceid);
            return dbMan.ExecuteNonQuery_S(StoredProcedureName, Parameters);
        }
        public int insert_device(string devicename)
        {
            string query = "insert into devices (Name,InMaintenance) values ('" + devicename + "'," + 0 + ")";
            return dbMan.ExecuteNonQuery(query);
            //string StoredProcedureName = StoredProcedures.InsertDevice;
            //Dictionary<string, object> Parameters = new Dictionary<string, object>();
            //Parameters.Add("@DeviceId", deviceid);
            //Parameters.Add("@DeviceName", devicename);
            //return dbMan.ExecuteNonQuery_S(StoredProcedureName, Parameters);
        }
        //---------------------------------------------------------------
        public DataTable Select_Number_of_Inventory_Items()
        {
            /*string query = " Select Count(*) From Inventory; ";
            //return dbMan.ExecuteReader(query);*/
            string StoredProcedureName = StoredProcedures.SelectNumberofInventoryItems;
            return dbMan.ExecuteReader_S(StoredProcedureName, null);
        }

        public DataTable Select_Inventory_Items()
        {
            /*string query = " Select ProductName,Capacity,MinCapacity From Inventory; ";
            //return dbMan.ExecuteReader(query);*/
            string StoredProcedureName = StoredProcedures.SelectInventoryItems;
            return dbMan.ExecuteReader_S(StoredProcedureName, null);

        }
        public int Update_Inventory_Item_Capacity(int newCap, string ProductName)
        {
            /*string query = "Update Inventory Set Capacity = " + newCap + " Where ProductName = '" + ProductName + "'; ";
            return dbMan.ExecuteNonQuery(query);*/
            string StoredProcedureName = StoredProcedures.ChangeInventoryCapacity;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@newCap", newCap);
            Parameters.Add("@ProductName", ProductName);
            return dbMan.ExecuteNonQuery_S(StoredProcedureName, Parameters);
        }
    }
}
