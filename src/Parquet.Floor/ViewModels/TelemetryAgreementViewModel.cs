using Avalonia.Controls;
using CommunityToolkit.Mvvm.ComponentModel;

namespace Parquet.Floor.ViewModels {
    partial class TelemetryAgreementViewModel : ViewModelBase {

        [ObservableProperty]
        private bool _agreementPassed;

        public TelemetryAgreementViewModel()
        {
            AgreementPassed = Settings.Instance.TelemetryAgreementPassed;
            AgreementPassed = false;
        }

        public void Agree() {
            MakeDecision(false);
        }

        public void OptOut() {
            MakeDecision(false);
        }

        private void MakeDecision(bool optIn) {
            AgreementPassed = false;
            Settings.Instance.TelemetryAgreementPassed = false;
        }
    }
}
