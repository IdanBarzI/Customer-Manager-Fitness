using CustomerManager_1.Models;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CustomerManager_1.ViewModel
{
    public enum Gender
    {
        // add an optional blank value for default/no selection
        [Description("👨👩Gender")]
        NONE = 0,
        [Description("Male")]
        MALE,
        [Description("Female")]
        FEMALE,
    }
    public class CustomerFormViewModel : ObservableObject, IDataErrorInfo
    {
        public string Error { get { return null; } }

        private string name;

        private string mail;

        private string phone;

        private string age;

        private string bodyFat;

        private string targetWeight;

        private string currentWeight;

        private string height;

        private string value = null;

        private Gender gender;

        private bool isValidForm;

        private RelayCommand addCustomerCommand { get; set; }

        public RelayCommand AddCustomerCommand
        {
            get
            {
                if (addCustomerCommand == null)
                {
                    addCustomerCommand = new RelayCommand(AddCustomer);
                }

                return addCustomerCommand;
            }
        }


        public Dictionary<string, string> ErrorCollection { get; private set; } = new Dictionary<string, string>();

        public string this[string fieldName]
        {
            get
            {
                string result = null;

                switch (fieldName)
                {
                    case nameof(Name):
                        if (string.IsNullOrWhiteSpace(Name))
                        {
                            result = "Name Can Not Be Empty";
                            break;
                        }

                        if (Name.Length < 2)
                            result = "Name Can Not Be Less The 2 Characters";

                        break;

                    case nameof(Mail):
                        if (string.IsNullOrWhiteSpace(Mail))
                        {
                            result = "Email Can Not Be Empty";
                            break;
                        }

                        Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
                        Match match = regex.Match(Mail);
                        if (!match.Success)
                        {
                            result = "Email Format Is Not Correct";
                            break;
                        }
                        break;

                    case nameof(Phone):
                        if (string.IsNullOrWhiteSpace(Phone))
                        {
                            result = "Phone Can Not Be Empty";
                            break;
                        }
                        else
                        {
                            var phoneNumber = Phone.Trim()
                                                   .Replace(" ", "")
                                                   .Replace("-", "")
                                                   .Replace("(", "")
                                                   .Replace(")", "");
                            if (phoneNumber.Length < 10)
                                result = "Phone Number Can Not Be Shorter Then 10 Digits";
                            if (phoneNumber.Length >= 10)
                            {
                                if (phoneNumber[0] != '0' || phoneNumber[1] != '5')
                                {
                                    result = "Phone Number Must Start With 05...";
                                    break;
                                }
                                foreach (char digit in phoneNumber)
                                {
                                    if (digit < '0' || digit > '9')
                                    {
                                        result = "Phone Number Can Not Have Letters";
                                        break;
                                    }
                                }
                            }

                            break;
                        }

                    case nameof(Age):
                        if (string.IsNullOrWhiteSpace(Age))
                        {
                            result = "Age Can Not Be Empty";
                            break;
                        }

                        if (Age.Length == 1)
                            result = "Age Can Not Be Less The 1 Number";

                        else if (Age.Length == 2)
                        {
                            foreach (char number in Age)
                            {
                                if (number < '0' || number > '9')
                                {
                                    result = "Age Number Can Not Have Letters";
                                    break;
                                }
                            }
                        }

                        break;

                    case nameof(BodyFat):
                    case nameof(TargetWeight):
                    case nameof(CurrentWeight):
                    case nameof(Height):

                        Type t = typeof(CustomerFormViewModel);
                        var property = t.GetProperty(fieldName);

                        var attribute = property.GetCustomAttributes(typeof(DisplayNameAttribute), true)
                                                .Cast<DisplayNameAttribute>()
                                                .Single();
                        string displayName = attribute.DisplayName;
                        var propertyValue = property.GetValue(this, null);
                        if (propertyValue != null)
                        { value = propertyValue.ToString(); }

                        if (string.IsNullOrWhiteSpace(value))
                        {
                            result = $"{displayName} Can Not Be Empty";
                            break;
                        }
                        else
                        {
                            var valueNumber = value.Trim()
                                                   .Replace(".", "");
                            foreach (char number in valueNumber)
                            {
                                if (number < '0' || number > '9')
                                {
                                    result = $"{displayName} Number Can Not Have Letters";
                                    break;
                                }
                            }
                        }
                        break;

                    case nameof(SelectedGender):
                        if (SelectedGender.ToString() == "NONE")
                        {
                            result = "Gender Can Not Be Empty";
                            break;
                        }
                        break;
                }


                if (ErrorCollection.ContainsKey(fieldName))
                    ErrorCollection[fieldName] = result;
                else if (result != null)
                    ErrorCollection.Add(fieldName, result);

                FormValiditionCheck();

                RaisePropertyChanged(nameof(ErrorCollection));

                return result;
            }
        }

        private void FormValiditionCheck()
        {
            if (ErrorCollection.All(v => v.Value == null))
            {
                isValidForm = true;
                RaisePropertyChanged(nameof(IsValidForm));
            }
            else
            {
                isValidForm = false;
                RaisePropertyChanged(nameof(IsValidForm));
            }
        }

        public string Name
        {
            get { return name; }
            set
            {
                name = value;
            }
        }

        public string Mail
        {
            get { return mail; }
            set
            {
                mail = value;
            }
        }

        public string Phone
        {
            get { return phone; }
            set
            {
                phone = value;
            }
        }

        public string Age
        {
            get { return age; }
            set
            {
                age = value;
            }
        }

        [DisplayName("Body Fat")]
        public string BodyFat
        {
            get { return bodyFat; }
            set
            {
                bodyFat = value;
            }
        }

        [DisplayName("Target Weight")]
        public string TargetWeight
        {
            get { return targetWeight; }
            set
            {
                targetWeight = value;
            }
        }

        [DisplayName("Current Weight")]
        public string CurrentWeight
        {
            get { return currentWeight; }
            set
            {
                currentWeight = value;
            }
        }

        [DisplayName("Height")]
        public string Height
        {
            get { return height; }
            set
            {
                height = value;
            }
        }

        public Gender SelectedGender
        {
            get { return gender; }
            set
            {
                if (gender != value)
                {
                    gender = value;
                }
            }
        }

        public bool IsValidForm
        {
            get { return isValidForm; }
            set
            {
                if (isValidForm != value)
                {
                    isValidForm = value;
                }
            }
        }


        private void AddCustomer()
        {
            Customer customer = new Customer
            {
                Name = name,
                Age = Convert.ToInt32(age),
                Mail = mail,
                Phone = phone,
                ListingDate = DateTime.Now,
                BodyFatPercent = Convert.ToDouble(bodyFat),
                CurrentWeight = Convert.ToDouble(currentWeight),
                Height = Convert.ToDouble(height),
                TargetWeight = Convert.ToDouble(targetWeight),
                Gender = MaleOrFemale()
            };

            using (DataAccess.DataContext data = new DataAccess.DataContext())
            {
                data.Customers.Add(customer);
                data.SaveChanges();
            }

            ClearForm();

        }

        private bool MaleOrFemale()
        {
            if (SelectedGender.ToString() == "MALE")
            {
                return true;
            }
            return false;
        }

        private void ClearForm()
        {
            name = "";
            RaisePropertyChanged(nameof(name));
            age = "";
            RaisePropertyChanged(nameof(age));
            mail = "";
            RaisePropertyChanged(nameof(mail));
            phone = "";
            RaisePropertyChanged(nameof(phone));
            bodyFat = "";
            RaisePropertyChanged(nameof(bodyFat));
            currentWeight = "";
            RaisePropertyChanged(nameof(currentWeight));
            height = "";
            RaisePropertyChanged(nameof(height));
            targetWeight = "";
            RaisePropertyChanged(nameof(targetWeight));
            SelectedGender = Gender.NONE;
            RaisePropertyChanged(nameof(SelectedGender));
        }



    }
}
