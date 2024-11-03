using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RD_PowerMorph_Generator.Helpers
{
    internal class VisualIndicatorController
    {
        private readonly FormMain _formMain;

        public VisualIndicatorController(FormMain formMain)
        {
            _formMain = formMain;
        }

        public void SetInitial()
        {
            // pbXmlsLoadStatus - X
            // pbDefBodyLoad - X
            // pbInisOutputDir -- forbidden
            // pbGeneratorState -- forbidden
            // pbBodyGenUpdateState -- forbidden

            try
            {
                var pbXmlsLoadStatus = _formMain.Controls.Find("pbXmlsLoadStatus", true).FirstOrDefault() as PictureBox;
                var pbDefBodyLoad = _formMain.Controls.Find("pbDefBodyLoad", true).FirstOrDefault() as PictureBox;
                var pbInisOutputDir = _formMain.Controls.Find("pbInisOutputDir", true).FirstOrDefault() as PictureBox;
                var pbGeneratorState = _formMain.Controls.Find("pbGeneratorState", true).FirstOrDefault() as PictureBox;
                var pbBodyGenUpdateState = _formMain.Controls.Find("pbBodyGenUpdateState", true).FirstOrDefault() as PictureBox;

                if (pbXmlsLoadStatus != null)
                {
                    pbXmlsLoadStatus.Image = ByteArrayToImage(Properties.Resources.Everaldo_Crystal_Clear_Action_cancel);
                }

                if (pbDefBodyLoad != null)
                {
                    pbDefBodyLoad.Image = ByteArrayToImage(Properties.Resources.Everaldo_Crystal_Clear_Action_cancel);
                }

                if (pbInisOutputDir != null)
                {
                    pbInisOutputDir.Image = ByteArrayToImage(Properties.Resources.Everaldo_Crystal_Clear_Action_delete);
                }

                if (pbGeneratorState != null)
                {
                    pbGeneratorState.Image = ByteArrayToImage(Properties.Resources.Everaldo_Crystal_Clear_Action_delete);
                }

                if (pbBodyGenUpdateState != null)
                {
                    pbBodyGenUpdateState.Image = ByteArrayToImage(Properties.Resources.Everaldo_Crystal_Clear_Action_delete);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void SetPbOk(string pbName) {
            var targetPb = _formMain.Controls.Find(pbName, true).FirstOrDefault() as PictureBox;
            if (targetPb != null) {
                targetPb.Image = ByteArrayToImage(Properties.Resources.Everaldo_Crystal_Clear_Action_ok);
            }
        }

        public void SetPbNotOk(string pbName) {
            var targetPb = _formMain.Controls.Find(pbName, true).FirstOrDefault() as PictureBox;
            if (targetPb != null) {
                targetPb.Image = ByteArrayToImage(Properties.Resources.Everaldo_Crystal_Clear_Action_cancel);
            }
        }

        public void SetPbPlus(string pbName) {
            var targetPb = _formMain.Controls.Find(pbName, true).FirstOrDefault() as PictureBox;
            if (targetPb != null) {
                targetPb.Image = ByteArrayToImage(Properties.Resources.Everaldo_Crystal_Clear_Action_edit_add);
            }
        }

        public void SetPbWorking(string pbName) {
            var targetPb = _formMain.Controls.Find(pbName, true).FirstOrDefault() as PictureBox;
            if (targetPb != null) {
                targetPb.Image = ByteArrayToImage(Properties.Resources.Everaldo_Crystal_Clear_Action_run);
            }
        }

        private Image ByteArrayToImage(byte[] byteArray)
        {
            using (var ms = new MemoryStream(byteArray))
            {
                return Image.FromStream(ms);
            }
        }
    }
}
