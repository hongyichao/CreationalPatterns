// See https://aka.ms/new-console-template for more information


using Singleton;

Logger logger = Logger.GetInstance("file1");

logger.write("something...1");

logger.write("something...2");

Logger logger2 = Logger.GetInstance("file1");

logger2.write("something...3");

Logger logger3 = Logger.GetInstance("file2");

logger3.write("something meaningful...");

