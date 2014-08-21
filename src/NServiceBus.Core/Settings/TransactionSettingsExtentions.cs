namespace NServiceBus
{
    using Settings;

    /// <summary>
    /// Provides a hook to allows users fine grained control over transactionality
    /// </summary>
    public static class TransactionSettingsExtentions
    {
        /// <summary>
        /// Entry point for transaction related configuration
        /// </summary>
        /// <param name="config"><see cref="Configure"/> instance.</param>
        public static TransactionSettings Transactions(this ConfigurationBuilder config)
        {
            return new TransactionSettings(config);
        }
    }
}