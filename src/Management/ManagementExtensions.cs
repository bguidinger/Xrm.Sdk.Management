namespace BGuidinger.Xrm.Sdk.Management
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public static class ManagementExtensions
    {
        public static async Task<Region[]> GetCurrencies(this ManagementClient client)
        {
            var request = new GetCurrencies();
            return await client.Execute<Region[]>(request);
        }
        public static async Task<InstanceBackup[]> GetInstanceBackups(this ManagementClient client, string instanceId)
        {
            var request = new GetInstanceBackups()
            {
                InstanceId = instanceId
            };
            return await client.Execute<InstanceBackup[]>(request);
        }
        public static async Task<InstanceBackup> GetInstanceBackup(this ManagementClient client, string instanceId, string backupId)
        {
            var request = new GetInstanceBackup()
            {
                InstanceId = instanceId,
                BackupId = backupId
            };
            return await client.Execute<InstanceBackup>(request);
        }
        public static async Task<OperationStatus> BackupInstance(this ManagementClient client, string instanceId, string label, string notes, AzureStorage storage = null)
        {
            var request = new BackupInstance()
            {
                InstanceId = instanceId,
                Label = label,
                Notes = notes
            };
            return await client.Execute<OperationStatus>(request);
        }
        public static async Task<InstanceTypeInfo[]> GetInstanceTypesInfo(this ManagementClient client)
        {
            var request = new GetInstanceTypesInfo();
            return await client.Execute<InstanceTypeInfo[]>(request);
        }
        public static async Task<InstanceTypeInfo> GetInstanceTypeInfo(this ManagementClient client, InstanceType type)
        {
            var request = new GetInstanceTypeInfo()
            {
                Type = type
            };
            return await client.Execute<InstanceTypeInfo>(request);
        }
        public static async Task<Instance[]> GetInstances(this ManagementClient client)
        {
            var request = new GetInstances();
            return await client.Execute<Instance[]>(request);
        }
        public static async Task<Instance> GetInstance(this ManagementClient client, string instanceId)
        {
            var request = new GetInstance()
            {
                Id = instanceId
            };
            return await client.Execute<Instance>(request);
        }
        public static async Task<OperationStatus> ApplyUser(this ManagementClient client, string instanceId, string userId)
        {
            var request = new ApplyUser()
            {
                InstanceId = instanceId,
                UserId = userId
            };
            return await client.Execute<OperationStatus>(request);
        }
        public static async Task<OperationStatus> ConfigureInstance(this ManagementClient client, string instanceId, string purpose, bool validate = false, IDictionary<string, string> properties = null)
        {
            var request = new ConfigureInstance()
            {
                InstanceId = instanceId,
                Purpose = purpose,
                Validate = validate,
                AdditionalProperties = properties
            };
            return await client.Execute<OperationStatus>(request);
        }
        public static async Task<OperationStatus> DeleteInstance(this ManagementClient client, string instanceId, bool validate = false)
        {
            var request = new DeleteInstance()
            {
                InstanceId = instanceId,
                Validate = validate
            };
            return await client.Execute<OperationStatus>(request);
        }
        public static async Task<OperationStatus> ProvisionInstance(this ManagementClient client, NewInstance instance, bool validate = false)
        {
            var request = new ProvisionInstance()
            {
                Type = instance.Type,
                DomainName = instance.DomainName,
                FriendlyName = instance.FriendlyName,
                InitialUserEmail = instance.InitialUserEmail,
                Purpose = instance.Purpose,
                SecurityGroupId = instance.SecurityGroupId,
                BaseLanguage = instance.BaseLanguage,
                Currency = instance.Currency,
                ServiceVersionId = instance.ServiceVersionId,
                Templates = instance.Templates,
                AdditionalProperties = instance.AdditionalProperties,
                Validate = validate
            };
            return await client.Execute<OperationStatus>(request);
        }
        public static async Task<OperationStatus> ResetInstance(this ManagementClient client, string instanceId, InstanceReset instance)
        {
            var request = new ResetInstance()
            {
                InstanceId = instanceId,
                DomainName = instance.DomainName,
                FriendlyName = instance.FriendlyName,
                ApplicationNames = instance.ApplicationNames,
                Currency = instance.Currency,
                Purpose = instance.Purpose,
                BaseLanguageCode = instance.BaseLanguageCode,
                PreferredCulture = instance.PreferredCulture,
                TargetRelease = instance.TargetRelease,
                SecurityGroupId = instance.SecurityGroupId,
                AdditionalProperties = instance.AdditionalProperties
            };
            return await client.Execute<OperationStatus>(request);
        }
        public static async Task<OperationStatus> RestoreInstance(this ManagementClient client, string targetInstanceId, InstanceRestorePoint restorePoint)
        {
            var request = new RestoreInstance()
            {
                TargetInstanceId = targetInstanceId,
                SourceInstanceId = restorePoint.SourceInstanceId,
                InstanceBackupId = restorePoint.InstanceBackupId,
                Label = restorePoint.Label,
                CreatedOn = restorePoint.CreatedOn
            };
            return await client.Execute<OperationStatus>(request);
        }
        public static async Task<OperationStatus> UpdateAdminMode(this ManagementClient client, string instanceId, bool enabled, string notification = "", bool validate = false)
        {
            var request = new UpdateAdminMode()
            {
                InstanceId = instanceId,
                Validate = validate,
                AdminMode = enabled,
                BackgroundOperationsEnabled = !enabled,
                NotificationText = notification
            };
            return await client.Execute<OperationStatus>(request);
        }
        public static async Task<Language[]> GetLanguages(this ManagementClient client, string versionId)
        {
            var request = new GetLanguages()
            {
                VersionId = versionId
            };
            return await client.Execute<Language[]>(request);
        }
        public static async Task<UserNotification[]> GetAllNotifications(this ManagementClient client, string tenantId, string adminId, string[] environments)
        {
            var request = new GetAllNotifications()
            {
                TenantId = tenantId,
                AdminId = adminId,
                Environments = environments
            };
            return await client.Execute<UserNotification[]>(request);
        }
        public static async Task<OperationStatus> PostNotification(this ManagementClient client, UserNotification notification)
        {
            var request = new PostUserNotification()
            {
                TenantId = notification.TenantId,
                OrgId = notification.OrgId,
                AdminId = notification.AdminId,
                NotificationId = notification.NotificationId,
                Content = notification.Content,
                Priority = notification.Priority,
                State = notification.State,
                Environments = notification.Environments,
                CreatedAt = notification.CreatedAt
            };
            return await client.Execute<OperationStatus>(request);
        }
        public static async Task<OperationStatus> GetOperationStatus(this ManagementClient client, string id)
        {
            var request = new GetOperationStatus()
            {
                Id = id
            };
            return await client.Execute<OperationStatus>(request);
        }
        public static async Task<ServiceVersion[]> GetServiceVersions(this ManagementClient client)
        {
            var request = new GetServiceVersions();
            return await client.Execute<ServiceVersion[]>(request);
        }
        public static async Task<Template[]> GetTemplates(this ManagementClient client)
        {
            var request = new GetTemplates();
            return await client.Execute<Template[]>(request);
        }
        public static async Task<TenantApplicationIdentity[]> GetTenantApplicationIdentities(this ManagementClient client)
        {
            var request = new GetTenantApplicationIdentities();
            return await client.Execute<TenantApplicationIdentity[]>(request);
        }
        public static async Task<TenantApplicationIdentity> GetTenantApplicationIdentity(this ManagementClient client, string id)
        {
            var request = new GetTenantApplicationIdentity()
            {
                Id = id
            };
            return await client.Execute<TenantApplicationIdentity>(request);
        }
        public static async Task<TenantApplicationIdentity> CreateTenantApplicationIdentity(this ManagementClient client, TenantApplicationIdentity identity)
        {
            var request = new CreateTenantApplicationIdentity()
            {
                Id = identity.Id,
                TenantId = identity.TenantId,
                AadApplicationId = identity.AadApplicationId,
                Enabled = identity.Enabled,
                CreatedOn = identity.CreatedOn,
                ModifiedOn = identity.ModifiedOn
            };
            return await client.Execute<TenantApplicationIdentity>(request);
        }
        public static async Task<OperationStatus> EnableTenantApplicationIdentity(this ManagementClient client, string id)
        {
            var request = new EnableTenantApplicationIdentity()
            {
                Id = id
            };
            return await client.Execute<OperationStatus>(request);
        }
        public static async Task<OperationStatus> DeleteTenantApplicationIdentity(this ManagementClient client, string id)
        {
            var request = new DeleteTenantApplicationIdentity()
            {
                Id = id
            };
            return await client.Execute<OperationStatus>(request);
        }
        public static async Task<OperationStatus> DisableTenantApplicationIdentity(this ManagementClient client, string id)
        {
            var request = new DisableTenantApplicationIdentity()
            {
                Id = id
            };
            return await client.Execute<OperationStatus>(request);
        }
    }
}