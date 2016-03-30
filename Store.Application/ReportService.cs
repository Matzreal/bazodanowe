using System;
using System.Collections.Generic;
using System.Linq;
using Store.Domain.Model.Report;
using Store.Domain.Repositories;

namespace Store.Application
{
    public class ReportService : IReportService
    {
        private readonly IReportRepository _reportRepository;

        public ReportService(IReportRepository reportRepository)
        {
            _reportRepository = reportRepository;
        }

        public void Delete(Guid id)
        {
            _reportRepository.Delete(id);
        }

        public IList<Report> GetAll()
        {
            return _reportRepository.GetAll().ToList();
        }

        public Report GetById(Guid id)
        {
            return _reportRepository.GetById(id);
        }

        public void Insert(Report obj)
        {
            _reportRepository.Insert(obj);
        }
    }
}
