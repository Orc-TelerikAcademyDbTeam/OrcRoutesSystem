namespace Reports.ReportTypes
{
    using System;
    using System.Collections.Generic;
    using System.Data.OleDb;

    using global::Reports.ReportModels;

    internal static class ExcelReport
    {
        public static ICollection<FuelInfo> ReadFuelInfo(string filePath)
        {
            var result = new List<FuelInfo>();
            var con = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = "+filePath+"; Extended Properties = \"Excel 12.0 Xml; HDR = YES; IMEX = 2\"");

            con.Open();
            using (con)
            {
                var dtExcelSchema = con.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
                var sheetName = dtExcelSchema.Rows[0]["TABLE_NAME"];
                var command = new OleDbCommand("SELECT * FROM " + "["+sheetName+"]", con);
                var reader = command.ExecuteReader();
                int i = 0;
                while (reader.Read())
                {
                    if (reader[0]==DBNull.Value)
                    {
                        return result;
                    }
                    var info = new FuelInfo();
                    info.FuelId = Convert.ToInt32(reader[0]);
                    info.VehicleId = Convert.ToInt32(reader[1]);
                    info.Price = Convert.ToDecimal(reader[2]);
                    info.Spent = Convert.ToDecimal(reader[3]);
                    info.Total = Convert.ToDecimal(reader[4]);
                    result.Add(info);
                }
            }
            return result;
        }
    }
}