﻿using System;

namespace Common.Logging.NLog
{
  public class NLogLogger : LoggerBase
  {
    internal NLogLogger(string name, global::NLog.Logger logger)
      : base(name)
    {
      _logger = logger;
    }

    public override void Debug(string message, params object[] parameters)
    {
      if (IsDebugEnabled)
        Log(global::NLog.LogLevel.Debug, null, message, parameters);
    }

    public override void Debug(Exception exception, string message, params object[] parameters)
    {
      if (IsDebugEnabled)
        Log(global::NLog.LogLevel.Debug, exception, message, parameters);
    }

    public override void Error(string message, params object[] parameters)
    {
      if (IsErrorEnabled)
        Log(global::NLog.LogLevel.Error, null, message, parameters);
    }

    public override void Error(Exception exception, string message, params object[] parameters)
    {
      if (IsErrorEnabled)
        Log(global::NLog.LogLevel.Error, exception, message, parameters);
    }

    public override void Fatal(string message, params object[] parameters)
    {
      if (IsFatalEnabled)
        Log(global::NLog.LogLevel.Fatal, null, message, parameters);
    }

    public override void Fatal(Exception exception, string message, params object[] parameters)
    {
      if (IsFatalEnabled)
        Log(global::NLog.LogLevel.Fatal, exception, message, parameters);
    }

    public override void Info(string message, params object[] parameters)
    {
      if (IsInfoEnabled)
        Log(global::NLog.LogLevel.Info, null, message, parameters);
    }

    public override void Info(Exception exception, string message, params object[] parameters)
    {
      if (IsInfoEnabled)
        Log(global::NLog.LogLevel.Info, exception, message, parameters);
    }

    public override void Trace(string message, params object[] parameters)
    {
      if (IsTraceEnabled)
        Log(global::NLog.LogLevel.Trace, null, message, parameters);
    }

    public override void Trace(Exception exception, string message, params object[] parameters)
    {
      if (IsTraceEnabled)
        Log(global::NLog.LogLevel.Trace, exception, message, parameters);
    }

    public override void Warn(string message, params object[] parameters)
    {
      if (IsWarnEnabled)
        Log(global::NLog.LogLevel.Warn, null, message, parameters);
    }

    public override void Warn(Exception exception, string message, params object[] parameters)
    {
      if (IsWarnEnabled)
        Log(global::NLog.LogLevel.Warn, exception, message, parameters);
    }

    public override bool IsDebugEnabled
    {
      get { return _logger.IsDebugEnabled; }
    }

    public override bool IsErrorEnabled
    {
      get { return _logger.IsErrorEnabled; }
    }

    public override bool IsFatalEnabled
    {
      get { return _logger.IsFatalEnabled; }
    }

    public override bool IsInfoEnabled
    {
      get { return _logger.IsInfoEnabled; }
    }

    public override bool IsTraceEnabled
    {
      get { return _logger.IsTraceEnabled; }
    }

    public override bool IsWarnEnabled
    {
      get { return _logger.IsWarnEnabled; }
    }

    protected void Log(global::NLog.LogLevel logLevel, Exception exception, string message, params object[] parameters)
    {
      var logEvent = new global::NLog.LogEventInfo(logLevel, Name, null, message, parameters, exception);
      _logger.Log(logEvent);
    }

    private readonly global::NLog.Logger _logger;
  }
}