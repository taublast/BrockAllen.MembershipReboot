﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BrockAllen.MembershipReboot.Resources {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class ValidationMessages {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal ValidationMessages() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("BrockAllen.MembershipReboot.Resources.ValidationMessages", typeof(ValidationMessages).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The email address for this account is already verified..
        /// </summary>
        public static string AccountAlreadyVerified {
            get {
                return ResourceManager.GetString("AccountAlreadyVerified", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Account closed..
        /// </summary>
        public static string AccountClosed {
            get {
                return ResourceManager.GetString("AccountClosed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Can&apos;t create an account because there was no email from the identity provider..
        /// </summary>
        public static string AccountCreateFailNoEmailFromIdp {
            get {
                return ResourceManager.GetString("AccountCreateFailNoEmailFromIdp", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to To login, this account must be configured with certificates..
        /// </summary>
        public static string AccountNotConfiguredWithCertificates {
            get {
                return ResourceManager.GetString("AccountNotConfiguredWithCertificates", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to To login, this account must be configured with mobile phone number..
        /// </summary>
        public static string AccountNotConfiguredWithMobilePhone {
            get {
                return ResourceManager.GetString("AccountNotConfiguredWithMobilePhone", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to This account is not configured with a secret question or answer..
        /// </summary>
        public static string AccountNotConfiguredWithSecretQuestion {
            get {
                return ResourceManager.GetString("AccountNotConfiguredWithSecretQuestion", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The email address for this account is not yet verified..
        /// </summary>
        public static string AccountNotVerified {
            get {
                return ResourceManager.GetString("AccountNotVerified", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to This account requires a secret question and answer to reset the password..
        /// </summary>
        public static string AccountPasswordResetRequiresSecretQuestion {
            get {
                return ResourceManager.GetString("AccountPasswordResetRequiresSecretQuestion", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Add a client certificate to enable certificate two factor authentication..
        /// </summary>
        public static string AddClientCertForTwoFactor {
            get {
                return ResourceManager.GetString("AddClientCertForTwoFactor", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to You must set a password on the local account before you remove the last external login provider..
        /// </summary>
        public static string CantRemoveLastLinkedAccountIfNoPassword {
            get {
                return ResourceManager.GetString("CantRemoveLastLinkedAccountIfNoPassword", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to That certificate is already in use by a different account..
        /// </summary>
        public static string CertificateAlreadyInUse {
            get {
                return ResourceManager.GetString("CertificateAlreadyInUse", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Code required..
        /// </summary>
        public static string CodeRequired {
            get {
                return ResourceManager.GetString("CodeRequired", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Email already in use..
        /// </summary>
        public static string EmailAlreadyInUse {
            get {
                return ResourceManager.GetString("EmailAlreadyInUse", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Email is required..
        /// </summary>
        public static string EmailRequired {
            get {
                return ResourceManager.GetString("EmailRequired", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Attempts to login have been exceeded.
        /// </summary>
        public static string FailedLoginAttemptsExceeded {
            get {
                return ResourceManager.GetString("FailedLoginAttemptsExceeded", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid certificate..
        /// </summary>
        public static string InvalidCertificate {
            get {
                return ResourceManager.GetString("InvalidCertificate", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid username or password..
        /// </summary>
        public static string InvalidCredentials {
            get {
                return ResourceManager.GetString("InvalidCredentials", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid email..
        /// </summary>
        public static string InvalidEmail {
            get {
                return ResourceManager.GetString("InvalidEmail", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid key..
        /// </summary>
        public static string InvalidKey {
            get {
                return ResourceManager.GetString("InvalidKey", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid name..
        /// </summary>
        public static string InvalidName {
            get {
                return ResourceManager.GetString("InvalidName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid new password..
        /// </summary>
        public static string InvalidNewPassword {
            get {
                return ResourceManager.GetString("InvalidNewPassword", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid old password..
        /// </summary>
        public static string InvalidOldPassword {
            get {
                return ResourceManager.GetString("InvalidOldPassword", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid password..
        /// </summary>
        public static string InvalidPassword {
            get {
                return ResourceManager.GetString("InvalidPassword", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid phone number..
        /// </summary>
        public static string InvalidPhone {
            get {
                return ResourceManager.GetString("InvalidPhone", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid secret question or answer..
        /// </summary>
        public static string InvalidQuestionOrAnswer {
            get {
                return ResourceManager.GetString("InvalidQuestionOrAnswer", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid tenant..
        /// </summary>
        public static string InvalidTenant {
            get {
                return ResourceManager.GetString("InvalidTenant", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid username..
        /// </summary>
        public static string InvalidUsername {
            get {
                return ResourceManager.GetString("InvalidUsername", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The external account is already associated with another user..
        /// </summary>
        public static string LinkedAccountAlreadyInUse {
            get {
                return ResourceManager.GetString("LinkedAccountAlreadyInUse", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Can&apos;t login with this provider because the email is already associated with another account. Please login with your local account and then associate the provider..
        /// </summary>
        public static string LoginFailEmailAlreadyAssociated {
            get {
                return ResourceManager.GetString("LoginFailEmailAlreadyAssociated", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Login not allowed for this account..
        /// </summary>
        public static string LoginNotAllowed {
            get {
                return ResourceManager.GetString("LoginNotAllowed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to That mobile phone is already in use by a different account..
        /// </summary>
        public static string MobilePhoneAlreadyInUse {
            get {
                return ResourceManager.GetString("MobilePhoneAlreadyInUse", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Mobile phone number must be different then the current..
        /// </summary>
        public static string MobilePhoneMustBeDifferent {
            get {
                return ResourceManager.GetString("MobilePhoneMustBeDifferent", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Mobile phone number required..
        /// </summary>
        public static string MobilePhoneRequired {
            get {
                return ResourceManager.GetString("MobilePhoneRequired", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to That name is already in use..
        /// </summary>
        public static string NameAlreadyInUse {
            get {
                return ResourceManager.GetString("NameAlreadyInUse", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Name is required..
        /// </summary>
        public static string NameRequired {
            get {
                return ResourceManager.GetString("NameRequired", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The new password must be different than the old password..
        /// </summary>
        public static string NewPasswordMustBeDifferent {
            get {
                return ResourceManager.GetString("NewPasswordMustBeDifferent", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The parent group is already a child of the child group..
        /// </summary>
        public static string ParentGroupAlreadyChild {
            get {
                return ResourceManager.GetString("ParentGroupAlreadyChild", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The parent and child are the same group..
        /// </summary>
        public static string ParentGroupSameAsChild {
            get {
                return ResourceManager.GetString("ParentGroupSameAsChild", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Password must contain at least {0} of the following characters: one upper, one lower, one digit and one other..
        /// </summary>
        public static string PasswordComplexityRules {
            get {
                return ResourceManager.GetString("PasswordComplexityRules", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Password must be at least {0} characters long..
        /// </summary>
        public static string PasswordLength {
            get {
                return ResourceManager.GetString("PasswordLength", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Password is required..
        /// </summary>
        public static string PasswordRequired {
            get {
                return ResourceManager.GetString("PasswordRequired", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Password reset is not possible since there is no verified email address for this account..
        /// </summary>
        public static string PasswordResetErrorNoEmail {
            get {
                return ResourceManager.GetString("PasswordResetErrorNoEmail", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Register a mobile phone number to enable mobile two factor authentication..
        /// </summary>
        public static string RegisterMobileForTwoFactor {
            get {
                return ResourceManager.GetString("RegisterMobileForTwoFactor", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Reopening the account is not possible since there is no email address for this account..
        /// </summary>
        public static string ReopenErrorNoEmail {
            get {
                return ResourceManager.GetString("ReopenErrorNoEmail", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Secret answer required..
        /// </summary>
        public static string SecretAnswerRequired {
            get {
                return ResourceManager.GetString("SecretAnswerRequired", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to That password reset secret question is already being used..
        /// </summary>
        public static string SecretQuestionAlreadyInUse {
            get {
                return ResourceManager.GetString("SecretQuestionAlreadyInUse", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Secret question required..
        /// </summary>
        public static string SecretQuestionRequired {
            get {
                return ResourceManager.GetString("SecretQuestionRequired", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Tenant is required..
        /// </summary>
        public static string TenantRequired {
            get {
                return ResourceManager.GetString("TenantRequired", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Username already in use..
        /// </summary>
        public static string UsernameAlreadyInUse {
            get {
                return ResourceManager.GetString("UsernameAlreadyInUse", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Username cannot contain the &apos;@&apos; character..
        /// </summary>
        public static string UsernameCannotContainAtSign {
            get {
                return ResourceManager.GetString("UsernameCannotContainAtSign", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Username cannot have two spaces, periods, dashes or underscores next to one another..
        /// </summary>
        public static string UsernameCannotRepeatSpecialCharacters {
            get {
                return ResourceManager.GetString("UsernameCannotRepeatSpecialCharacters", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Username can begin or end only with a letter or digit..
        /// </summary>
        public static string UsernameCanOnlyStartOrEndWithLetterOrDigit {
            get {
                return ResourceManager.GetString("UsernameCanOnlyStartOrEndWithLetterOrDigit", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Username can only contain letters, digits, spaces, periods, dashes or underscores..
        /// </summary>
        public static string UsernameOnlyContainsValidCharacters {
            get {
                return ResourceManager.GetString("UsernameOnlyContainsValidCharacters", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Username is required..
        /// </summary>
        public static string UsernameRequired {
            get {
                return ResourceManager.GetString("UsernameRequired", resourceCulture);
            }
        }
    }
}
