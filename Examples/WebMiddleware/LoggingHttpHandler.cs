using Microsoft.Extensions.Logging;
using System.Diagnostics;

namespace WebMiddleware
{
    public class LoggingHttpHandler : DelegatingHandler
    {
        private readonly ILogger<LoggingHttpHandler> _logger;

        public LoggingHttpHandler(ILogger<LoggingHttpHandler> logger)
        {
            _logger = logger;
        }

        protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            try
            {
                var sw = Stopwatch.StartNew();
                var response = await base.SendAsync(request, cancellationToken).ConfigureAwait(false);

                sw.Stop();

                if (sw.ElapsedMilliseconds > 3000)
                {
                    _logger.LogWarning("{Method} {RequestUri} took {ElapsedMilliseconds} ms.", request.Method, request.RequestUri, sw.ElapsedMilliseconds);
                }

                string? requestBody = null;
                if (request.Content != null)
                {
                    requestBody = await request.Content.ReadAsStringAsync().ConfigureAwait(false);
                }

                var success = response?.IsSuccessStatusCode ?? false;

                _logger.Log(success ? LogLevel.Trace : LogLevel.Warning, "Outgoing Request: {method} {url}, Body: {body}.", request?.Method, request?.RequestUri, requestBody);

                string? responseBody = null;
                if (response?.Content != null)
                {
                    responseBody = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                }

                _logger.Log(success ? LogLevel.Trace : LogLevel.Warning, "Incoming Response: {response}, Body: {body}.", response?.ToString(), responseBody);

                return response;
            }
            catch (Exception e)
            {
                _logger.LogError(e, "Error during call.");
                throw;
            }
        }
    }
}
