﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KinoCentar.Shared.Models.Izvjestaji;
using KinoCentar.Shared.Util;
using KinoCentar.WinUI.Extensions;
using Microsoft.Reporting.WinForms;
using KinoCentar.Shared.Extensions;
using System.Globalization;

namespace KinoCentar.WinUI.Forms.Izvjestaji
{
    public partial class frmIzvjestajiProdajaPoDatumu : Form
    {
        private WebAPIHelper izvjestajiService = new WebAPIHelper(Global.ApiAddress, Global.IzvjestajiRoute, Global.PrijavljeniKorisnik);

        public frmIzvjestajiProdajaPoDatumu()
        {
            InitializeComponent();
        }

        private void frmIzvjestajiProdajaPoMjesecu_Load(object sender, EventArgs e)
        {
                        
        }

        private void btnPrikazi_Click(object sender, EventArgs e)
        {
            if (dtpDatumOd.Value.Date <= dtpDatumDo.Value.Date)
            {
                string dateTimeFrom = dtpDatumOd.Value.Date.ToString("yyyy-MM-dd'T'HH:mm:ss");
                string dateTimeTo = dtpDatumDo.Value.Date.ToString("yyyy-MM-dd'T'HH:mm:ss");

                var response = izvjestajiService.GetActionResponse("ProdajaPoDatumu", dateTimeFrom, dateTimeTo).Handle();
                if (response.IsSuccessStatusCode)
                {
                    var dataSource = response.GetResponseResult<List<ProdajaIzvjestajModel>>();
                    ReportDataSource rds = new ReportDataSource("dsIzvjestaji", dataSource);

                    this.rwShowIzvjestaj.Reset();
                    this.rwShowIzvjestaj.LocalReport.DataSources.Clear();
                    this.rwShowIzvjestaj.LocalReport.ReportEmbeddedResource = "KinoCentar.WinUI.Forms.Izvjestaji.Reports.ProdajaPoDatumuReport.rdlc";
                    this.rwShowIzvjestaj.LocalReport.DataSources.Add(rds);
                    this.rwShowIzvjestaj.LocalReport.SetParameters(new ReportParameter("Korisnik", Global.PrijavljeniKorisnik.ImePrezime));
                    this.rwShowIzvjestaj.LocalReport.SetParameters(new ReportParameter("OdDatuma", dtpDatumOd.Value.Date.ToString("dd.MM.yyyy", CultureInfo.InvariantCulture)));
                    this.rwShowIzvjestaj.LocalReport.SetParameters(new ReportParameter("DoDatuma", dtpDatumDo.Value.Date.ToString("dd.MM.yyyy", CultureInfo.InvariantCulture)));
                    this.rwShowIzvjestaj.RefreshReport();
                }
            }
        }
    }
}
