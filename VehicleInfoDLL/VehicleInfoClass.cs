/* Title:           Vehicle Info Class
 * Date:            8-25-17
 * Author:          Terry Holmes */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewEventLogDLL;

namespace VehicleInfoDLL
{
    public class VehicleInfoClass
    {
        //setting up the classes
        EventLogClass TheEventLogClass = new EventLogClass();

        VehicleInfoDataSet aVehicleInfoDataSet;
        VehicleInfoDataSetTableAdapters.vehicleinfoTableAdapter aVehicleInfoTableAdapter;

        InsertVehicleInfoEntryTableAdapters.QueriesTableAdapter aInsertVehicleInfoTableAdapter;

        UpdateVehicleInfoStatusEntryTableAdapters.QueriesTableAdapter aUpdateVehicleInfoStatusTableAdapter;

        UpdateVehicleInfoIMEIEntryTableAdapters.QueriesTableAdapter aUpdateVehicleInfoIMEITableAdapter;

        UpdateVehicleInfoTamperTagEntryTableAdapters.QueriesTableAdapter aUpdateVehicleInfoTamperTagTableAdapter;

        FindVehiclesByDOTStatusDataSet aFindVehiclesByDOTStatusDataSet;
        FindVehiclesByDOTStatusDataSetTableAdapters.FindVehiclesByDOTStatusTableAdapter aFindVehiclesByDOTStatusTableAdapter;

        FindVehicleInfoByBJCNumberDataSet aFindVehicleInfoByBJCNumberDataSet;
        FindVehicleInfoByBJCNumberDataSetTableAdapters.FindVehicleInfoByBJCNumberTableAdapter aFindVehicleInfoByBJCNumberTableAdapter;

        FindVehicleInfoByIMEIDataSet aFindVehicleInfoByIMEIDataSet;
        FindVehicleInfoByIMEIDataSetTableAdapters.FindVehicleInfoByIMEITableAdapter aFindVehicleInfoByIMEITableAdapter;

        FindActiveCDLVehiclesDataSet aFindActiveCDLVehiclesDataSet;
        FindActiveCDLVehiclesDataSetTableAdapters.FindActiveCDLVehiclesTableAdapter aFindActiveCDLVehiclesTableAdapter;

        FindActiveNonCDLVehiclesDataSet aFindActiveNonCDLVehiclesDataSet;
        FindActiveNonCDLVehiclesDataSetTableAdapters.FindActiveNonCDLVehiclesTableAdapter aFindActiveNonCDLVehiclesTableAdapter;

        FindActiveMedicalCardVehiclesDataSet aFindActiveMedicalCardVehiclesDataSet;
        FindActiveMedicalCardVehiclesDataSetTableAdapters.FindActiveMedicalCardVehiclesTableAdapter aFindActiveMedicalCardVehiclesTableAdapter;

        FindActiveNonMedicalCardVehiclesDataSet aFindActiveNonMedicalCardVehiclesDataSet;
        FindActiveNonMedicalCardVehiclesDataSetTableAdapters.FindActiveNonMedicalCardVehiclesTableAdapter aFindActiveNonMedicalCardVehiclesTableAdapter;

        VehicleInfoHistoryDataSet aVehicleInfoHistoryDataSet;
        VehicleInfoHistoryDataSetTableAdapters.vehicleinfohistoryTableAdapter aVehicleInfoHistoryTableAdatper;

        InsertVehicleInfoHistoryEntryTableAdapters.QueriesTableAdapter aInsertVehicleInfoHistoryTableAdapter;

        FindVehicleInfoHistoryByBJCNumberDataSet aFindVehicleInfoHistoryByBJCNumberDataSet;
        FindVehicleInfoHistoryByBJCNumberDataSetTableAdapters.FindVehicleInfoHistoryByBJCNumberTableAdapter aFindVehicleInfoHistoryByBJCNumberTableAdapter;

        FindVehicleInfoHistoryByDateRangeDataSet aFindVehicleInfoHistoryByDateRangeDataSet;
        FindVehicleInfoHistoryByDateRangeDataSetTableAdapters.FindVehicleInfoHistoryByDateRangeTableAdapter aFindVehicleInfoHistoryByDateRangeTableAdapter;

        DOTStatusDataSet aDOTStatusDataSet;
        DOTStatusDataSetTableAdapters.dotstatusTableAdapter aDOTStatusTableAdapter;

        InsertDOTStatusEntryTableAdapters.QueriesTableAdapter aInsertDOTStatusTableAdapter;

        FindDOTStatusSortedDataSet aFindDOTStatusSortedDataSet;
        FindDOTStatusSortedDataSetTableAdapters.FindDOTStatusSortedTableAdapter aFindDOTStatusSortedTableAdapter;

        FindDOTStatusByIDDataSet aFindDOTStatusByIDDataSet;
        FindDOTStatusByIDDataSetTableAdapters.FindDOTStatusByIDTableAdapter aFindDOTStatusByIDTableAdapter;

        GPSPlugStatusDataSet aGPSPlugStatusDataSet;
        GPSPlugStatusDataSetTableAdapters.gpsplugstatusTableAdapter aGPSPlugStatusTableAdapter;

        InsertGPSPlugStatusEntryTableAdapters.QueriesTableAdapter aInsertGPSPlugStatusTableAdapter;

        FindGPSPlugStatusSortedDataSet aFindGPSPlugStatusDataSet;
        FindGPSPlugStatusSortedDataSetTableAdapters.FindGPSPlugStatusSortedTableAdapter aFindGPSPlugStatusSortedTableAdapter;

        FindGPSPlugStatusByIDDataSet aFindGPSPlugStatusByIDDataSet;
        FindGPSPlugStatusByIDDataSetTableAdapters.FindGPSPlugStatusByIDTableAdapter aFindGPSPlugStatusByIDTableAdapter;

        FindDOTStatusByStatusDataSet aFindDOTStatusByStatusDataSet;
        FindDOTStatusByStatusDataSetTableAdapters.FindDOTStatusByStatusTableAdapter aFindDOTStatusByStatusTableAdapter;

        FindGPSStatusByStatusDataSet aFindGPSStatusByStatusDataSet;
        FindGPSStatusByStatusDataSetTableAdapters.FindGPSStatusByStatusTableAdapter aFindGPSStatusByStatusTableAdapter;

        FindActiveVehicleInfoSortedDataSet aFindActiveVehicleInfoSortedDataSet;
        FindActiveVehicleInfoSortedDataSetTableAdapters.FindActiveVehicleInfoSortedTableAdapter aFindActiveVehicleInfoSortedTableAdapter;

        FindVehicleInfoByVehicleNumberDataSet aFindVehicleInfoByVehicleNumberDataSet;
        FindVehicleInfoByVehicleNumberDataSetTableAdapters.FindVehicleInfoByVehicleNumberTableAdapter aFindVehicleInfoByVehicleNumberTableAdapter;

        public FindVehicleInfoByVehicleNumberDataSet FindVehicleInfoByVehicleNumber(string strVehicleNumber)
        {
            try
            {
                aFindVehicleInfoByVehicleNumberDataSet = new FindVehicleInfoByVehicleNumberDataSet();
                aFindVehicleInfoByVehicleNumberTableAdapter = new FindVehicleInfoByVehicleNumberDataSetTableAdapters.FindVehicleInfoByVehicleNumberTableAdapter();
                aFindVehicleInfoByVehicleNumberTableAdapter.Fill(aFindVehicleInfoByVehicleNumberDataSet.FindVehicleInfoByVehicleNumber, strVehicleNumber);
            }
            catch (Exception EX)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Vehicle Info Class // Find Vehicle Info By Vehicle Number " + EX.Message);
            }

            return aFindVehicleInfoByVehicleNumberDataSet;
        }
        public FindActiveVehicleInfoSortedDataSet FindActiveVehicleInfoSorted()
        {
            try
            {
                aFindActiveVehicleInfoSortedDataSet = new FindActiveVehicleInfoSortedDataSet();
                aFindActiveVehicleInfoSortedTableAdapter = new FindActiveVehicleInfoSortedDataSetTableAdapters.FindActiveVehicleInfoSortedTableAdapter();
                aFindActiveVehicleInfoSortedTableAdapter.Fill(aFindActiveVehicleInfoSortedDataSet.FindActiveVehicleInfoSorted);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Vehicle Info Class // Find Active Vehicle Info Sorted " + Ex.Message);
            }

            return aFindActiveVehicleInfoSortedDataSet;
        }
        public FindGPSStatusByStatusDataSet FindGPSStatusByStatus(string strGPSStatus)
        {
            try
            {
                aFindGPSStatusByStatusDataSet = new FindGPSStatusByStatusDataSet();
                aFindGPSStatusByStatusTableAdapter = new FindGPSStatusByStatusDataSetTableAdapters.FindGPSStatusByStatusTableAdapter();
                aFindGPSStatusByStatusTableAdapter.Fill(aFindGPSStatusByStatusDataSet.FindGPSStatusByStatus, strGPSStatus);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Vehicle Info Class // Find GPS Status By Status " + Ex.Message);
            }

            return aFindGPSStatusByStatusDataSet;
        }
        public FindDOTStatusByStatusDataSet FindDOTStatusByStatus(string strStatus)
        {
            try
            {
                aFindDOTStatusByStatusDataSet = new FindDOTStatusByStatusDataSet();
                aFindDOTStatusByStatusTableAdapter = new FindDOTStatusByStatusDataSetTableAdapters.FindDOTStatusByStatusTableAdapter();
                aFindDOTStatusByStatusTableAdapter.Fill(aFindDOTStatusByStatusDataSet.FindDOTStatusByStatus, strStatus);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Vehicle Info Class // Find DOT Status By Status " + Ex.Message);
            }

            return aFindDOTStatusByStatusDataSet;
        }
        public FindGPSPlugStatusByIDDataSet FindGPSPlugStatusByID(int intGPSStatusID)
        {
            try
            {
                aFindGPSPlugStatusByIDDataSet = new FindGPSPlugStatusByIDDataSet();
                aFindGPSPlugStatusByIDTableAdapter = new FindGPSPlugStatusByIDDataSetTableAdapters.FindGPSPlugStatusByIDTableAdapter();
                aFindGPSPlugStatusByIDTableAdapter.Fill(aFindGPSPlugStatusByIDDataSet.FindGPSPlugStatusByID, intGPSStatusID);
               
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Find GPS Status By ID " + Ex.Message);
            }

            return aFindGPSPlugStatusByIDDataSet;
        }
        public FindGPSPlugStatusSortedDataSet FindGPSPlugStatusSorted()
        {
            try
            {
                aFindGPSPlugStatusDataSet = new FindGPSPlugStatusSortedDataSet();
                aFindGPSPlugStatusSortedTableAdapter = new FindGPSPlugStatusSortedDataSetTableAdapters.FindGPSPlugStatusSortedTableAdapter();
                aFindGPSPlugStatusSortedTableAdapter.Fill(aFindGPSPlugStatusDataSet.FindGPSPlugStatusSorted);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Vehicle Info Class // Find GPS Plug Status Sorted " + Ex.Message);
            }

            return aFindGPSPlugStatusDataSet;
        }
        public bool InsertGPSPlugStatus(string strPlugStatus)
        {
            bool blnFatalError = false;

            try
            {
                aInsertGPSPlugStatusTableAdapter = new InsertGPSPlugStatusEntryTableAdapters.QueriesTableAdapter();
                aInsertGPSPlugStatusTableAdapter.InsertGPSPlugStatus(strPlugStatus);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Vehicle Info Class // Insert GPS Plug Status " + Ex.Message);

                return blnFatalError;
            }

            return blnFatalError;
        }
        public GPSPlugStatusDataSet GetGPSPlugStatusInfo()
        {
            try
            {
                aGPSPlugStatusDataSet = new GPSPlugStatusDataSet();
                aGPSPlugStatusTableAdapter = new GPSPlugStatusDataSetTableAdapters.gpsplugstatusTableAdapter();
                aGPSPlugStatusTableAdapter.Fill(aGPSPlugStatusDataSet.gpsplugstatus);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Vehicle Info Class // Get GPS Plug Status " + Ex.Message);
            }

            return aGPSPlugStatusDataSet;
        }
        public void UpdateGPSPlugStatusDB(GPSPlugStatusDataSet aGPSPlugStatusDataSet)
        {
            try
            {
                aGPSPlugStatusTableAdapter = new GPSPlugStatusDataSetTableAdapters.gpsplugstatusTableAdapter();
                aGPSPlugStatusTableAdapter.Update(aGPSPlugStatusDataSet.gpsplugstatus);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Vehicle Info Class // Update GPS Plug Status DB " + Ex.Message);
            }
        }
        public FindDOTStatusByIDDataSet FindDOTStatusByID(int intDOTStatusID)
        {
            try
            {
                aFindDOTStatusByIDDataSet = new FindDOTStatusByIDDataSet();
                aFindDOTStatusByIDTableAdapter = new FindDOTStatusByIDDataSetTableAdapters.FindDOTStatusByIDTableAdapter();
                aFindDOTStatusByIDTableAdapter.Fill(aFindDOTStatusByIDDataSet.FindDOTStatusByID, intDOTStatusID);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Vehicle Info Class // Find DOT Status By ID " + Ex.Message);
            }

            return aFindDOTStatusByIDDataSet;
        }
        public FindDOTStatusSortedDataSet FindDOTStatusSorted()
        {
            try
            {
                aFindDOTStatusSortedDataSet = new FindDOTStatusSortedDataSet();
                aFindDOTStatusSortedTableAdapter = new FindDOTStatusSortedDataSetTableAdapters.FindDOTStatusSortedTableAdapter();
                aFindDOTStatusSortedTableAdapter.Fill(aFindDOTStatusSortedDataSet.FindDOTStatusSorted);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Vehicle Info Class // Find DOT Status Sorted " + Ex.Message);
            }

            return aFindDOTStatusSortedDataSet;
        }
        public bool InsertDOTStatus(string strDOTStatus)
        {
            bool blnFatalError = false;

            try
            {
                aInsertDOTStatusTableAdapter = new InsertDOTStatusEntryTableAdapters.QueriesTableAdapter();
                aInsertDOTStatusTableAdapter.InsertDOTStatus(strDOTStatus);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Vehicle Info Classa // Insert DOT Status " + Ex.Message);

                blnFatalError = true;
            }

            return blnFatalError;
        }
        public DOTStatusDataSet GetDOTStatusInfo()
        {
            try
            {
                aDOTStatusDataSet = new DOTStatusDataSet();
                aDOTStatusTableAdapter = new DOTStatusDataSetTableAdapters.dotstatusTableAdapter();
                aDOTStatusTableAdapter.Fill(aDOTStatusDataSet.dotstatus);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Vehicle Info Class // Get DOT Status Info " + Ex.Message);
            }

            return aDOTStatusDataSet;
        }
        public void UpdateDOTStatusDB(DOTStatusDataSet aDOTStatusDataSet)
        {
            try
            {
                aDOTStatusTableAdapter = new DOTStatusDataSetTableAdapters.dotstatusTableAdapter();
                aDOTStatusTableAdapter.Update(aDOTStatusDataSet.dotstatus);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Vehicle Info Class // Update DOT Status DB " + Ex.Message);
            }
        }
        public FindVehicleInfoHistoryByDateRangeDataSet FindVehicleInfoHistoryByDateRange(DateTime datStartDate, DateTime datEndDate)
        {
            try
            {
                aFindVehicleInfoHistoryByDateRangeDataSet = new FindVehicleInfoHistoryByDateRangeDataSet();
                aFindVehicleInfoHistoryByDateRangeTableAdapter = new FindVehicleInfoHistoryByDateRangeDataSetTableAdapters.FindVehicleInfoHistoryByDateRangeTableAdapter();
                aFindVehicleInfoHistoryByDateRangeTableAdapter.Fill(aFindVehicleInfoHistoryByDateRangeDataSet.FindVehicleInfoHistoryByDateRange, datStartDate, datEndDate);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Vehicle Info Class // Find Vehicle Info History By Date Range " + Ex.Message);
            }

            return aFindVehicleInfoHistoryByDateRangeDataSet;
        }
        public FindVehicleInfoHistoryByBJCNumberDataSet FindVehicleInfoHistoryByBJCNumber(int intBJCNumber, DateTime datStartDate, DateTime datEndDate)
        {
            try
            {
                aFindVehicleInfoHistoryByBJCNumberDataSet = new FindVehicleInfoHistoryByBJCNumberDataSet();
                aFindVehicleInfoHistoryByBJCNumberTableAdapter = new FindVehicleInfoHistoryByBJCNumberDataSetTableAdapters.FindVehicleInfoHistoryByBJCNumberTableAdapter();
                aFindVehicleInfoHistoryByBJCNumberTableAdapter.Fill(aFindVehicleInfoHistoryByBJCNumberDataSet.FindVehicleInfoHistoryByBJCNumber, intBJCNumber, datStartDate, datEndDate);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Vehicle Info Class // Find Vehicle Info History By BJC Number " + Ex.Message);
            }

            return aFindVehicleInfoHistoryByBJCNumberDataSet;
        }
        public bool InsertVehicleInfoHistory(int intVehicleInfoID, int intEmployeeID, string strFieldChange, string strValueChanged)
        {
            bool blnFatalError = false;

            try
            {
                aInsertVehicleInfoHistoryTableAdapter = new InsertVehicleInfoHistoryEntryTableAdapters.QueriesTableAdapter();
                aInsertVehicleInfoHistoryTableAdapter.InsertVehicleInfoHistory(intVehicleInfoID, intEmployeeID, strFieldChange, strValueChanged, DateTime.Now);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Vehicle Info Class // Insert Vehicle Info History " + Ex.Message);

                blnFatalError = true;
            }

            return blnFatalError;
        }
        public VehicleInfoHistoryDataSet GetVehicleInfoHistoryInfo()
        {
            try
            {
                aVehicleInfoHistoryDataSet = new VehicleInfoHistoryDataSet();
                aVehicleInfoHistoryTableAdatper = new VehicleInfoHistoryDataSetTableAdapters.vehicleinfohistoryTableAdapter();
                aVehicleInfoHistoryTableAdatper.Fill(aVehicleInfoHistoryDataSet.vehicleinfohistory);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Vehicle Info Class // Get Vehicle Info History Info " + Ex.Message);
            }

            return aVehicleInfoHistoryDataSet;
        }
        public void UpdateVehicleInfoHistoryDB(VehicleInfoHistoryDataSet aVehicleInfoHistoryDataSet)
        {
            try
            {
                aVehicleInfoHistoryTableAdatper = new VehicleInfoHistoryDataSetTableAdapters.vehicleinfohistoryTableAdapter();
                aVehicleInfoHistoryTableAdatper.Update(aVehicleInfoHistoryDataSet.vehicleinfohistory);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Vehicle Info Class // Update Vehicle Info History DB " + Ex.Message);
            }
        }
        public FindActiveNonMedicalCardVehiclesDataSet FindActiveNonMedicalCardVehicles()
        {
            try
            {
                aFindActiveNonMedicalCardVehiclesDataSet = new FindActiveNonMedicalCardVehiclesDataSet();
                aFindActiveNonMedicalCardVehiclesTableAdapter = new FindActiveNonMedicalCardVehiclesDataSetTableAdapters.FindActiveNonMedicalCardVehiclesTableAdapter();
                aFindActiveNonMedicalCardVehiclesTableAdapter.Fill(aFindActiveNonMedicalCardVehiclesDataSet.FindActiveNonMedicalCardVehicles);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Vehicle Info Class // Find Active Non Medical Card Vehicles " + Ex.Message);
            }

            return aFindActiveNonMedicalCardVehiclesDataSet;
        }
        public FindActiveMedicalCardVehiclesDataSet FindActiveMedicalCardVehicles()
        {
            try
            {
                aFindActiveMedicalCardVehiclesDataSet = new FindActiveMedicalCardVehiclesDataSet();
                aFindActiveMedicalCardVehiclesTableAdapter = new FindActiveMedicalCardVehiclesDataSetTableAdapters.FindActiveMedicalCardVehiclesTableAdapter();
                aFindActiveMedicalCardVehiclesTableAdapter.Fill(aFindActiveMedicalCardVehiclesDataSet.FindActiveMedicalCardVehicles);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Vehicle Info Class // find Active Medicla Card Vehicles " + Ex.Message);
            }

            return aFindActiveMedicalCardVehiclesDataSet;
        }
        public FindActiveNonCDLVehiclesDataSet FindActiveNonCDLVehicles()
        {
            try
            {
                aFindActiveNonCDLVehiclesDataSet = new FindActiveNonCDLVehiclesDataSet();
                aFindActiveNonCDLVehiclesTableAdapter = new FindActiveNonCDLVehiclesDataSetTableAdapters.FindActiveNonCDLVehiclesTableAdapter();
                aFindActiveNonCDLVehiclesTableAdapter.Fill(aFindActiveNonCDLVehiclesDataSet.FindActiveNonCDLVehicles);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Vehicle Info Class // Find Active Non CDL Vehicles " + Ex.Message);
            }

            return aFindActiveNonCDLVehiclesDataSet;
        }
        public FindActiveCDLVehiclesDataSet FindActiveCDLVehicles()
        {
            try
            {
                aFindActiveCDLVehiclesDataSet = new FindActiveCDLVehiclesDataSet();
                aFindActiveCDLVehiclesTableAdapter = new FindActiveCDLVehiclesDataSetTableAdapters.FindActiveCDLVehiclesTableAdapter();
                aFindActiveCDLVehiclesTableAdapter.Fill(aFindActiveCDLVehiclesDataSet.FindActiveCDLVehicles);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Vehicle Info Class // Find Active CDL Vehicles " + Ex.Message);
            }

            return aFindActiveCDLVehiclesDataSet;
        }
        public FindVehicleInfoByIMEIDataSet FindVehicleInfoByIMEI(string strIMEI)
        {
            try
            {
                aFindVehicleInfoByIMEIDataSet = new FindVehicleInfoByIMEIDataSet();
                aFindVehicleInfoByIMEITableAdapter = new FindVehicleInfoByIMEIDataSetTableAdapters.FindVehicleInfoByIMEITableAdapter();
                aFindVehicleInfoByIMEITableAdapter.Fill(aFindVehicleInfoByIMEIDataSet.FindVehicleInfoByIMEI, strIMEI);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Vehicle Info Class // Find Vehicle Info By IMEI " + Ex.Message);
            }

            return aFindVehicleInfoByIMEIDataSet;
        }
        public FindVehicleInfoByBJCNumberDataSet FindVehicleInfoByBJCNumber(int intBJCNumber)
        {
            try
            {
                aFindVehicleInfoByBJCNumberDataSet = new FindVehicleInfoByBJCNumberDataSet();
                aFindVehicleInfoByBJCNumberTableAdapter = new FindVehicleInfoByBJCNumberDataSetTableAdapters.FindVehicleInfoByBJCNumberTableAdapter();
                aFindVehicleInfoByBJCNumberTableAdapter.Fill(aFindVehicleInfoByBJCNumberDataSet.FindVehicleInfoByBJCNumber, intBJCNumber);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Vehicle Info Class // Find Vehicle Info By BJC Number " + Ex.Message);
            }

            return aFindVehicleInfoByBJCNumberDataSet;
        }
        public FindVehiclesByDOTStatusDataSet FindVehicleByDOTStatus(string strDOTStatus)
        {
            try
            {
                aFindVehiclesByDOTStatusDataSet = new FindVehiclesByDOTStatusDataSet();
                aFindVehiclesByDOTStatusTableAdapter = new FindVehiclesByDOTStatusDataSetTableAdapters.FindVehiclesByDOTStatusTableAdapter();
                aFindVehiclesByDOTStatusTableAdapter.Fill(aFindVehiclesByDOTStatusDataSet.FindVehiclesByDOTStatus, strDOTStatus);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Vehicle Info Class // Find Vehicle By DOT Status " + Ex.Message);
            }

            return aFindVehiclesByDOTStatusDataSet;
        }
        public bool UpdateVehicleInfoTamperTag(int intVehicleInfoID, int intTamperTag)
        {
            bool blnFatalError = false;

            try
            {
                aUpdateVehicleInfoTamperTagTableAdapter = new UpdateVehicleInfoTamperTagEntryTableAdapters.QueriesTableAdapter();
                aUpdateVehicleInfoTamperTagTableAdapter.UpdateVehicleInfoTamperTag(intVehicleInfoID, intTamperTag);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Vehicle Info Class // Update Vehicle Info Tamper Tag " + Ex.Message);

                blnFatalError = true;
            }

            return blnFatalError;
        }
        public bool UpdateVehicleInfoIMEI(int intVehicleInfoID, string strIMEI)
        {
            bool blnFatalError = false;

            try
            {
                aUpdateVehicleInfoIMEITableAdapter = new UpdateVehicleInfoIMEIEntryTableAdapters.QueriesTableAdapter();
                aUpdateVehicleInfoIMEITableAdapter.UpdateVehicleInfoIMEI(intVehicleInfoID, strIMEI);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Vehicle Info Class // Update Vehicle Info IMEI " + Ex.Message);

                blnFatalError = true;
            }

            return blnFatalError;
        }
        public bool UpdateVehicleInfoStatus(int intVehicleInfoID, bool blnCDLRequired, bool blnMedicalCardRequired, int intDOTStatusID, int intGPSStatusID, DateTime datTransactionDate)
        {
            bool blnFatalError = false;

            try
            {
                aUpdateVehicleInfoStatusTableAdapter = new UpdateVehicleInfoStatusEntryTableAdapters.QueriesTableAdapter();
                aUpdateVehicleInfoStatusTableAdapter.UpdateVehicleInfoStatus(intVehicleInfoID, blnCDLRequired, blnMedicalCardRequired, intDOTStatusID, intGPSStatusID, datTransactionDate);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Vehicle Info Class // Update Vehicle Info Status " + Ex.Message);

                blnFatalError = true;
            }

            return blnFatalError;
        }
        public bool InsertVehicleInfo(int intVehicleID, bool blnCDLRequired, bool blnMedicalCardRequired, int intDOTStatusID, int intGPSStatusID, string strIMEI, int intTamperTag)
        {
            bool blnFatalError = false;

            try
            {
                aInsertVehicleInfoTableAdapter = new InsertVehicleInfoEntryTableAdapters.QueriesTableAdapter();
                aInsertVehicleInfoTableAdapter.InsertVehicleInfo(intVehicleID, blnCDLRequired, blnMedicalCardRequired, intDOTStatusID, intGPSStatusID, strIMEI, intTamperTag, DateTime.Now);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Vehicle Info Class // Insert Vehicle Info " + Ex.Message);

                blnFatalError = true;
            }

            return blnFatalError;
        }

        public VehicleInfoDataSet GetVehicleInfoDB()
        {
            try
            {
                aVehicleInfoDataSet = new VehicleInfoDataSet();
                aVehicleInfoTableAdapter = new VehicleInfoDataSetTableAdapters.vehicleinfoTableAdapter();
                aVehicleInfoTableAdapter.Fill(aVehicleInfoDataSet.vehicleinfo);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Vehicle Info Class // Get Vehicle Info DB " + Ex.Message);
            }

            return aVehicleInfoDataSet;
        }
        public void UpdateVehicleInfoDB(VehicleInfoDataSet aVehicleInfoDataSet)
        {
            try
            {
                aVehicleInfoTableAdapter = new VehicleInfoDataSetTableAdapters.vehicleinfoTableAdapter();
                aVehicleInfoTableAdapter.Update(aVehicleInfoDataSet.vehicleinfo);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Vehicle Info Class // Update Vehicle Info DB " + Ex.Message);
            }
        }
    }
}
