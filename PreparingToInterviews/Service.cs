/*Сервис, выгружающий по заданным параметрам данные из БД в XML-файл, для дальнейшей загрузки в 1С. 
 Платформа - BPMonline*/
namespace RMF
{

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.ServiceModel;
    using System.ServiceModel.Activation;
    using System.ServiceModel.Web;
    using System.Text;
    using System.Web;
    using System.IO;
    using System.Xml;
    using System.Data;

    using Terrasoft.Core;
    using Terrasoft.Core.DB;
    using Terrasoft.Core.Entities;
    using Terrasoft.Core.Factories;
    using Terrasoft.Common;

    using Terrasoft.Configuration;
    using Terrasoft.Configuration.EKOConsts;



    [ServiceContract]
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Required)]
    public class Upload1cService
    {
        #region Fields: Private

        private UserConnection _userConnection;

        #endregion

        #region Properties: Private

        private UserConnection _userConnection;

        private UserConnection UserConnection
        {
            get { return _userConnection ?? (_userConnection = (UserConnection)HttpContext.Current.Session["UserConnection"]); }
        }

        #endregion

        #region Methods:Private

        private void FillXml(XmlWriter writer, IDataReader reader)
        {
            for (int i = 0; i < reader.FieldCount; i++)
            {
                writer.WriteElementString(reader.GetName(i), reader.GetValue(i).ToString());
            }
        }

        // C O N T A C T S
        private void WriteContactsToXml(XmlWriter writer, DateTime from, DateTime to)
        {
            writer.WriteStartElement("clients");

            //var result = new List<ContactTo1c>();
            var strQuery = string.Format(@"
			select  c.Id1c as [id], 
					c.Name as [name],
					'Физ. лицо' as [type],
					'true' as [borrower],
					'Россия' as [reg_country],
					case when c.GenderId = 'EEAC42EE-65B6-DF11-831A-001D60E938C6' then 'М' else 'Ж' end as [sex],
					CONVERT(date, c.BirthDate) as [birth_date],
					c.BirthCity as [birth_place],
					'Паспорт' as [document_type],
					c.DocumentSeries as [passport_series],
					c.DocumentNumber as [passport_number],
					c.IssuedBy as [passport_issued_by],
					c.UsrIssuedAt as [passport_issued_at],
					c.UnitAuthorityNumber as [unit_authority_number],
					CONVERT(date, c.IssuedOn) as [passport_issued_on],
					c.MobilePhone as [mobile_phone],
					c.Notes as [description],
					'Россия' as [regadr_country],

					regadr.RegionCode as [regadr_region],
					regadr.CityCode as [regadr_city],
					regadr.StreetCode as [regadr_street],
					regadr.HomeType as [regadr_home_type],
					regadr.building1 as [regadr_building1],
					regadr.StructureType as [regadr_structure_type],
					regadr.building2 as [regadr_building2],
					regadr.FlatType as [regadr_flat_type],
					regadr.aptOffice as [regadr_aptOffice],

					'Россия' as [resadr_country],

					resadr.RegionCode as [resadr_region],
					resadr.CityCode as [resadr_city],
					resadr.StreetCode as [resadr_street],
					resadr.HomeType as [resadr_home_type],
					resadr.building1 as [resadr_building1],
					resadr.StructureType as [resadr_structure_type],
					resadr.building2 as [resadr_building2],
					resadr.FlatType as [resadr_flat_type],
					resadr.aptOffice as [resadr_aptOffice]
			from contact c
			left join (select ca.ContactId, 
						 city.Code as [CityCode], 																													--  Code или cCode - П Р О В Е Р И Т Ь
						 region.OkbCode as [RegionCode],																											--  OkbCode З А М Е Н И Т Ь
						 street.KLADRCode as [StreetCode],
						 ca.UsrHomeType2Id as [HomeType],
						 ca.Building1 as [building1],
						 ca.UsrStructureType2Id as [StructureType],
						 ca.Building2 as [building2],
						 ca.UsrFlatType2Id as [FlatType],
						 ca.AptOffice as [aptOffice],
			 			 row_number() over (partition by lower(ca.ContactId) order by ca.ContactId) as rn
				  from ContactAddress ca 
					left join City city on city.Id = ca.CityId			
					left join Region region on region.Id = ca.RegionId 
					left join Street  on street.Id = ca.UsrSimpleSreetId																								
									  where ca.AddressTypeId = '4732DF9C-2CF4-E211-9884-00155D051801' ) regadr on c.Id = regadr.ContactId and regadr.rn = 1

			left join (select ca.ContactId, 
						 city.Code as CityCode, 																													--  Code или cCode - П Р О В Е Р И Т Ь
						 region.OkbCode as RegionCode,																												--  OkbCode З А М Е Н И Т Ь
						 street.KLADRCode as StreetCode,
						 ca.UsrHomeType2Id as [HomeType],
						 ca.Building1 as [building1],
						 ca.UsrStructureType2Id as [StructureType],
						 ca.Building2 as [building2],
						 ca.UsrFlatType2Id as [FlatType],
						 ca.AptOffice as [aptOffice],
						 row_number() over (partition by lower(ca.ContactId) order by ca.ContactId) as rn
				  from ContactAddress ca   
					left join City city on city.Id = ca.CityId			
					left join Region region on region.Id = ca.RegionId 
					left join Street  on street.Id = ca.UsrSimpleSreetId																								
									  where ca.AddressTypeId = '4F8B2D67-71D0-45FB-897E-CD4A308A97C0' ) resadr on c.Id = resadr.ContactId and resadr.rn = 1

			where c.TypeId = '00783EF6-F36B-1410-A883-16D83CAB0980' and ((CONVERT(date, c.CreatedOn) >= '{0}' and CONVERT(date, c.CreatedOn) <= '{1}') or (CONVERT(date, c.ModifiedOn) >= '{0}' and CONVERT(date, c.ModifiedOn) <= '{1}'))", from.ToString("yyyy-MM-dd"), to.ToString("yyyy-MM-dd"));

            using (var dbExecutor = UserConnection.EnsureDBConnection())
            {
                using (var reader = dbExecutor.ExecuteReader(strQuery))
                {
                    while (reader.Read())
                    {
                        writer.WriteStartElement("client");
                        writer.WriteElementString("id", reader["id"].ToString());
                        writer.WriteElementString("name", reader["name"].ToString());
                        writer.WriteElementString("type", reader["type"].ToString());
                        writer.WriteElementString("borrower", reader["borrower"].ToString());
                        writer.WriteElementString("reg_country", reader["reg_country"].ToString());
                        writer.WriteElementString("sex", reader["sex"].ToString());
                        writer.WriteElementString("birth_date", reader["birth_date"].ToString());
                        writer.WriteElementString("birth_place", reader["birth_place"].ToString());
                        writer.WriteElementString("document_type", reader["document_type"].ToString());
                        writer.WriteElementString("passport_series", reader["passport_series"].ToString());
                        writer.WriteElementString("passport_number", reader["passport_number"].ToString());
                        writer.WriteElementString("passport_issued_by", reader["passport_issued_by"].ToString());
                        writer.WriteElementString("passport_issued_at", reader["passport_issued_at"].ToString());
                        writer.WriteElementString("unit_authority_number", reader["unit_authority_number"].ToString());
                        writer.WriteElementString("passport_issued_on", reader["passport_issued_on"].ToString());
                        writer.WriteElementString("mobile_phone", reader["mobile_phone"].ToString());
                        writer.WriteElementString("description", reader["description"].ToString());

                        writer.WriteStartElement("registration_address");
                        writer.WriteElementString("country", reader["regadr_country"].ToString());
                        writer.WriteElementString("region", reader["regadr_region"].ToString());
                        writer.WriteElementString("city", reader["regadr_city"].ToString());
                        writer.WriteElementString("street", reader["regadr_street"].ToString());
                        writer.WriteElementString("home_type", reader["regadr_home_type"].ToString());
                        writer.WriteElementString("building1", reader["regadr_building1"].ToString());
                        writer.WriteElementString("structure_type", reader["regadr_structure_type"].ToString());
                        writer.WriteElementString("building2", reader["regadr_building2"].ToString());
                        writer.WriteElementString("flat_type", reader["regadr_flat_type"].ToString());
                        writer.WriteElementString("aptOffice", reader["regadr_aptOffice"].ToString());
                        writer.WriteEndElement();

                        writer.WriteStartElement("residence_address");
                        writer.WriteElementString("country", reader["resadr_country"].ToString());
                        writer.WriteElementString("region", reader["resadr_region"].ToString());
                        writer.WriteElementString("city", reader["resadr_city"].ToString());
                        writer.WriteElementString("street", reader["resadr_street"].ToString());
                        writer.WriteElementString("home_type", reader["resadr_home_type"].ToString());
                        writer.WriteElementString("building1", reader["resadr_building1"].ToString());
                        writer.WriteElementString("structure_type", reader["resadr_structure_type"].ToString());
                        writer.WriteElementString("building2", reader["resadr_building2"].ToString());
                        writer.WriteElementString("flat_type", reader["resadr_flat_type"].ToString());
                        writer.WriteElementString("aptOffice", reader["resadr_aptOffice"].ToString());
                        writer.WriteEndElement();

                        writer.WriteEndElement();
                    }
                }
            }

            writer.WriteEndElement();
        }

        // A P P L I C A T I O N S
        private void WriteApplicationsToXml(XmlWriter writer, DateTime from, DateTime to)
        {
            writer.WriteStartElement("applications");

            var strQuery = string.Format(@"
			select a.Id1c as [id],
				CONVERT(date, a.CreatedOn) as [date],
				a.ParameterGroupId as [product],
				a.StatusId as [status],
				c.Id1c as [client_id],
				a.LoanAmount as [amount],
				case when a.StatusId = '3BB6219C-F36B-1410-F093-E0CB4EC6147E' then CONVERT(date, a.ProceededOn) else null end as [deadline], -- ЕСЛИ ЗАЯВККА ОДОБРЕНА (МОЖЕТ И БЕХ ЭТОЙ ХУЙНИ НАДО БЫЛО),
				AmountPeriod as [period],
				case when (a.UsrPromoCode = 'undefined' or a.UsrPromoCode = 'null') then '' else a.UsrPromoCode end as [promocode]

			from Application a
			join Contact c on c.Id = a.ContactId
			where (CONVERT(date, a.CreatedOn) >= '{0}' and CONVERT(date, a.CreatedOn) <= '{1}') or (CONVERT(date, a.ModifiedOn) >= '{0}' and CONVERT(date, a.ModifiedOn) <= '{1}')", from.ToString("yyyy-MM-dd"), to.ToString("yyyy-MM-dd"));

            using (var dbExecutor = UserConnection.EnsureDBConnection())
            {
                using (var reader = dbExecutor.ExecuteReader(strQuery))
                {
                    while (reader.Read())
                    {
                        writer.WriteStartElement("application");
                        FillXml(writer, reader);
                        writer.WriteEndElement();
                    }
                }
            }

            writer.WriteEndElement();
        }

        // C O N T R A C T S
        private void WriteContractsToXml(XmlWriter writer, DateTime from, DateTime to)
        {
            writer.WriteStartElement("contracts");

            var strQuery = string.Format(@"
			select c.Id1c as [id],
					ctct.Id1c as [client],
					CONVERT(date, c.SignedOn) as [signed_on],
					CONVERT(date, c.ValidFrom) as [valid_from],
					c.LoanAmount as [amount],
					CONVERT(date, DATEADD(DAY, c.LoanPeriod, c.SignedOn)) as [end_date],
					c.Id1c as [application_id],
					case when (a.UsrPromoCode = 'undefined' or a.UsrPromoCode = 'null') then '' else a.UsrPromoCode end as [promocode]
			from Contract c
			join Application a on a.id = c.ApplicationId
			join Contact ctct on ctct.Id = c.ContactId
			where (CONVERT(date, c.CreatedOn) >= '{0}' and CONVERT(date, c.CreatedOn) <= '{1}') or (CONVERT(date, c.ModifiedOn) >= '{0}' and CONVERT(date, c.ModifiedOn) <= '{1}')", from.ToString("yyyy-MM-dd"), to.ToString("yyyy-MM-dd"));

            using (var dbExecutor = UserConnection.EnsureDBConnection())
            {
                using (var reader = dbExecutor.ExecuteReader(strQuery))
                {
                    while (reader.Read())
                    {
                        writer.WriteStartElement("contract");
                        FillXml(writer, reader);
                        writer.WriteEndElement();
                    }
                }
            }

            writer.WriteEndElement();
        }

        //  C A S H F L O W S
        private void WriteCashFlowsToXml(XmlWriter writer, DateTime from, DateTime to)
        {
            writer.WriteStartElement("cashflows");

            var strQuery = string.Format(@"
			 select cf.Id1c as [id],
					cf.Date as [date], 
					cf.TypeId as [type],
					cf.CategoryId as [category],
					cf.Amount as [amount],
					cf.WayId as [method],
					c.Id1c as [client_id],
					ctr.Id1c as [contract_id]
			 from Cashflow cf
			 left join Contract ctr on cf.ContractId = ctr.Id
			 left join Contact c on cf.ContractId = c.Id
			 where (CONVERT(date, cf.CreatedOn) >= '{0}' and CONVERT(date, cf.CreatedOn) <= '{1}') or (CONVERT(date, cf.ModifiedOn) >= '{0}' and CONVERT(date, cf.ModifiedOn) <= '{1}')", from.ToString("yyyy-MM-dd"), to.ToString("yyyy-MM-dd"));

            using (var dbExecutor = UserConnection.EnsureDBConnection())
            {
                using (var reader = dbExecutor.ExecuteReader(strQuery))
                {
                    while (reader.Read())
                    {
                        writer.WriteStartElement("cashflow");
                        FillXml(writer, reader);
                        writer.WriteEndElement();
                    }
                }
            }

            writer.WriteEndElement();
        }

        // P N L T R A N S A C T I O N S
        private void WritePnlTransactionsToXml(XmlWriter writer, DateTime from, DateTime to)
        {
            writer.WriteStartElement("pnltransactions");

            var strQuery = string.Format(@"
			 select pnl.Id1c as [id],
					pnl.Date as [date], 
					pnl.TypeId as [type],
					pnl.CategoryId as [category],
					pnl.Amount as [amount],
					c.Id1c as [client_id],
					ctr.Id1c as [contract_id]
			 from PNLTransaction pnl
			 left join Contract ctr on pnl.ContractId = ctr.Id
			 left join Contact c on pnl.ContractId = c.Id 
			 where (CONVERT(date, pnl.CreatedOn) >= '{0}' and CONVERT(date, pnl.CreatedOn) <= '{1}') or (CONVERT(date, pnl.ModifiedOn) >= '{0}' and CONVERT(date, pnl.ModifiedOn) <= '{1}')", from.ToString("yyyy-MM-dd"), to.ToString("yyyy-MM-dd"));

            using (var dbExecutor = UserConnection.EnsureDBConnection())
            {
                using (var reader = dbExecutor.ExecuteReader(strQuery))
                {
                    while (reader.Read())
                    {
                        writer.WriteStartElement("pnltransaction");
                        FillXml(writer, reader);
                        writer.WriteEndElement();
                    }
                }
            }

            writer.WriteEndElement();
        }

        #endregion

        #region Methods:Public

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "Upload?from={from}&to={to}", BodyStyle = WebMessageBodyStyle.WrappedRequest,
            RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Xml)]
        //[WebGet]
        public Stream Upload(DateTime from, DateTime to)
        {

            MemoryStream xmlStream = new MemoryStream();
            XmlDocument xmlDoc = new XmlDocument();
            StringBuilder sb = new StringBuilder();
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;
            settings.ConformanceLevel = ConformanceLevel.Auto;
            XmlWriter xmlWriter = XmlWriter.Create(sb, settings);


            xmlWriter.WriteStartDocument();
            xmlWriter.WriteStartElement("data");
            /* CONTACTS BEGIN */
            WriteContactsToXml(xmlWriter, from, to);
            /* CONTACTS END */

            /* APPLICATIONS BEGIN */
            WriteApplicationsToXml(xmlWriter, from, to);
            /* APPLICATIONS END */

            /* CONTRACTS BEGIN */
            WriteContractsToXml(xmlWriter, from, to);
            /* CONTRACTS END */

            /* CASH FLOWS BEGIN */
            WriteCashFlowsToXml(xmlWriter, from, to);
            /* CASH FLOWS END */

            /* PNLTransactions BEGIN */
            WritePnlTransactionsToXml(xmlWriter, from, to);
            /* PNLTransactions END */

            xmlWriter.WriteEndElement();
            xmlWriter.WriteEndDocument();
            xmlWriter.Flush();
            xmlDoc.LoadXml(sb.ToString());
            xmlDoc.Save(xmlStream);
            xmlStream.Position = 0;

            String headerInfo = "attachment; filename=upload1C.xml";
            WebOperationContext.Current.OutgoingResponse.Headers["Content-Disposition"] = headerInfo;

            return xmlStream;
        }
        #endregion

    }
}