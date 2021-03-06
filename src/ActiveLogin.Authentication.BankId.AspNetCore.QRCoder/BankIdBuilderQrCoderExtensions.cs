using ActiveLogin.Authentication.BankId.AspNetCore;
using ActiveLogin.Authentication.BankId.AspNetCore.Qr;
using ActiveLogin.Authentication.BankId.AspNetCore.QrCoder;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class BankIdBuilderQrCoderExtensions
    {
        public static IBankIdBuilder UseQrCoderQrCodeGenerator(this IBankIdBuilder builder)
        {
            var services = builder.AuthenticationBuilder.Services;

            services.AddTransient<IBankIdQrCodeGenerator, QrCoderBankIdQrCodeGenerator>();

            return builder;
        }
    }
}
