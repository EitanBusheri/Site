﻿using IsraelHiking.DataAccessInterfaces;
using log4net;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Http.ExceptionHandling;

namespace IsraelHiking.DataAccess
{
    public class Logger : ExceptionLogger, ILogger
    {
        private readonly ILog _log = LogManager.GetLogger(typeof(Logger));

        public void Info(string message)
        {
            _log.Info(message);
        }

        public void Debug(string message)
        {
            _log.Debug(message);
        }

        public void Warn(string message)
        {
            _log.Warn(message);
        }

        public void Error(string message)
        {
            _log.Error(message);
        }

        public override async Task LogAsync(ExceptionLoggerContext context, CancellationToken cancellationToken)
        {
            _log.Error(context.Exception.ToString());
            await base.LogAsync(context, cancellationToken);
        }

        public override void Log(ExceptionLoggerContext context)
        {
            _log.Error(context.Exception.ToString());
            base.Log(context);
        }
    }
}
