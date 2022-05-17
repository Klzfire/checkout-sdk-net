﻿namespace Checkout
{
    public enum FourOAuthScope
    {
        [FourOAuthScope("vault")] Vault,
        [FourOAuthScope("vault:instruments")] VaultInstruments,
        [FourOAuthScope("vault:tokenization")] VaultTokenization,
        [FourOAuthScope("vault:customers")] VaultCustomers,
        [FourOAuthScope("gateway")] Gateway,
        [FourOAuthScope("gateway:payment")] GatewayPayment,

        [FourOAuthScope("gateway:payment-details")]
        GatewayPaymentDetails,

        [FourOAuthScope("gateway:payment-authorizations")]
        GatewayPaymentAuthorization,

        [FourOAuthScope("gateway:payment-voids")]
        GatewayPaymentVoids,

        [FourOAuthScope("gateway:payment-captures")]
        GatewayPaymentCaptures,

        [FourOAuthScope("gateway:payment-refunds")]
        GatewayPaymentRefunds,
        [FourOAuthScope("gateway:moto")] GatewayMoto,
        [FourOAuthScope("fx")] Fx,

        [FourOAuthScope("payouts:bank-details")]
        PayoutsBankDetails,
        [FourOAuthScope("sessions:app")] SessionsApp,
        [FourOAuthScope("sessions:browser")] SessionsBrowser,
        [FourOAuthScope("disputes")] Disputes,
        [FourOAuthScope("disputes:view")] DisputesView,

        [FourOAuthScope("disputes:provide-evidence")]
        DisputesProvideEvidence,
        [FourOAuthScope("disputes:accept")] DisputesAccept,
        [FourOAuthScope("marketplace")] Marketplace,
        [FourOAuthScope("transfers")] Transfers,
        [FourOAuthScope("transfers:create")] TransfersCreate,
        [FourOAuthScope("transfers:view")] TransfersView,
        [FourOAuthScope("flow")] Flow,
        [FourOAuthScope("flow:workflows")] FlowWorkflows,
        [FourOAuthScope("flow:events")] FlowEvents,
        [FourOAuthScope("files")] Files,
        [FourOAuthScope("files:retrieve")] FilesRetrieve,
        [FourOAuthScope("files:upload")] FilesUpload,
        [FourOAuthScope("files:download")] FilesDownload,
        [FourOAuthScope("risk")] Risk,
        [FourOAuthScope("risk:assessments")] RiskAssessments,
        [FourOAuthScope("risk:settings")] RiskSettings,
        [FourOAuthScope("balances")] Balances,
        [FourOAuthScope("balances:view")] BalancesView,

        [FourOAuthScope("middleware")] Middleware,
        [FourOAuthScope("middleware:gateway")] MiddlewareGateway,

        [FourOAuthScope("middleware:payment-context")]
        MiddlewarePaymentContext,

        [FourOAuthScope("middleware:merchants-secret")]
        MiddlewareMerchantsSecret,

        [FourOAuthScope("middleware:merchants-public")]
        MiddlewareMerchantsPublic
    }
}