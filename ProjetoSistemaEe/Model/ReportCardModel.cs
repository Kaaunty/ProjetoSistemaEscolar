using ProjetoSistemaEe.DAO;
using ProjetoSistemaEe.Entidades;
using System;
using System.Collections.Generic;

namespace ProjetoSistemaEe.Model
{
    internal class ReportCardModel : IFunctionModel<ReportCard>
    {
        private ReportCardDAO dao = new ReportCardDAO();

        public List<ReportCard> GetEntities()
        {
            try
            {
                List<ReportCard> reportCards = new List<ReportCard>();
                reportCards = dao.GetReportCards();
                return reportCards;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Register(ReportCard reportCard)
        {
            try
            {
                dao.RegisterReportCard(reportCard);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Edit(ReportCard reportCard)
        {
            try
            {
                dao.EditReportCard(reportCard);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Delete(ReportCard reportCard)
        {
            try
            {
                dao.DeleteReportCard(reportCard);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}