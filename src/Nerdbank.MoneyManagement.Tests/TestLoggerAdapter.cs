﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Validation;
using Xunit.Abstractions;

internal class TestLoggerAdapter : TextWriter
{
    private readonly ITestOutputHelper logger;

    public TestLoggerAdapter(ITestOutputHelper testLogger)
    {
        Requires.NotNull(testLogger, nameof(testLogger));
        this.logger = testLogger;
    }

    public override Encoding Encoding => Encoding.Unicode;

    public override void WriteLine()
    {
        this.logger.WriteLine(string.Empty);
    }

    public override void WriteLine(object value)
    {
        this.logger.WriteLine(value.ToString());
    }

    public override void WriteLine(string value)
    {
        this.logger.WriteLine(value);
    }

    public override void WriteLine(string format, params object[] args)
    {
        this.logger.WriteLine(format, args);
    }
}
