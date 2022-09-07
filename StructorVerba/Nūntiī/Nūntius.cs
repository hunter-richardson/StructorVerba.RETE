using System;
using System.IO;

using log4net.Appender.RollingFileAppender;
using log4net.Core;
using Lombok.NET.MethodGenerators.AsyncGenerator;

namespace Nūntiī
{
  public sealed class Nūntius<Hoc>
  {
    private static readonly string Locus = "nūntia";
    private static readonly Func<Type, RollingFileAppender> Generātor =
              classis => new RollingFileAppender()
                              {
                                DatePattern                 = String.Empty,
                                MaximumFileSize             = "100KB",
                                MaxSizeRollBackups          = 10,
                                RollingStyle                = RollingMode.Size,
                                StaticLogFileName           = true,
                                PreserveLogFileNameExension = true,
                                Threshold                   = Level.Error,
                                #if DEBUG
                                Threshold                   = Level.All,
                                #endif
                                Name                        = classis.ToString(),
                                File                        = Path.Join(Path.DirectorySeparatorChar, Locus, $"{Praecō.Name}.log"),
                                AppendToFile                = File.Exists(Praecō.File),
                                Writer                      = new StreamWriter(new FileStream(Praecō.File, AppendToFile.Choose(FileMode.Append, FileMode.CreateNew),
                                                                                              FileAccess.Write, FileShare.Write, 4096, FileOptions.Asychronous | FileOptions.SequentialScan))
                              };

    private readonly RollingFileAppender Praecō { get; }
    private readonly Temporis Temporis { get => Temporis.Faciendum.Invoke(); }

    public Nūntius()
    {
      if (!Directory.Exists(Locus))
      {
        Directory.CreateDirectory(Locus);
      }

      Praecō = Generator.Invoke(typeof(Hoc));
      Praecō.ActivateOptions();
    }

    [Async] public sealed void Morior(in Exception error) => Nuntiō(Level.Fatal, error);

    [Async] public sealed void Terreō(in Exception error) => Nuntiō(Level.Error, error);

    private sealed async void Nūntiō(in LoggingEvent factum) => await Praecō.DoAppend(factum);

    private sealed async void Nūntiō(in Level gradus, in string nūnium)
              => await Praecō.DoAppend(new LoggingEvent(new LoggingEventData()
                                                        {
                                                          DateTime = DateTime.Now,
                                                          Domain = AppDomain.Name,
                                                          LoggerName = Praecō.Name,
                                                          Level = gradus,
                                                          LocationInfo = new LocationInfo(typeof(Hoc)),
                                                          Message = nūntium
                                                        }));

    private sealed async void Nūntiō(in Level gradus, in Exception error)
              => await Praecō.DoAppend(new LoggingEvent(new LoggingEventData()
                                                        {
                                                          DateTime = DateTime.Now,
                                                          Domain = AppDomain.CurrentDomain.FriendlyName,
                                                          ExceptionString = error.GetBaseException().Message,
                                                          LoggerName = Praecō.Name,
                                                          Level = gradus,
                                                          LocationInfo = new LocationInfo(typeof(Hoc)),
                                                        }));

    private sealed async void Nūntiō(in Level gradus, in params object nūntia)
    {
      (from nūntium in nūntia
       where nūntium is Exception
       select nūntium.Cast<Exception>())
            .ForEach(error => await Nūntiō(Ūtilitātēs.Seriēs(level, Level.Error).Min(), error));
      await Nūntiō(level, string.Join(' ', $"{typeof(Hoc).FullName}: [{Tempors.FormatDate(DateTime.Now)}] <{gradus}>",
                                           string.Join(' ', from nūntium in nūntia
                                                            where nūntium is not Exception
                                                            select nūntium.ToString())));
    }

    [Async] public sealed void Nōtō(in params object nūntia) => await Nūntiō(Level.Notice, nūntia);
    [Async] public sealed void Moneō(in params object nūntia) => await Nūntiō(Level.Warn, nūntia);
    [Async] public sealed void Certiōrō(in params object nūntia) => await Nūntiō(Level.Info, nūntia);
    [Async] public sealed void Garriō(in params object nūntia) => await Nūntiō(Level.Debug, nūntia);
    [Async] public sealed void PlūsGarriō(in params object nūntia) => await Nūntiō(Level.Trace, nūntia);
    [Async] public sealed void PlūrimumGarriō(in params object nūntia) => await Nūntiō(Level.Verbose, nūntia);
  }
}
