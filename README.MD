##Project to discover how works Structured logging & Serilog

* [Serilog](https://github.com/serilog/serilog)
* [Wiki](https://github.com/serilog/serilog/wiki)
* [Website](https://serilog.net/)

* [Very good introduction of the concepts](https://nblumhardt.com/2016/06/structured-logging-concepts-in-net-series-1/)

Structured logging is to pass from:

1. Take the description of an event and associated parameters
2. **Format** it into human-readable text
3. **Collect** the text
4. **Parse** (hard!) the text to recover individual parameter values
5. **Filter** based on parameters
6. **View** matching events

To:

1. Take the description of an event and associated parameters
2. **Capture** the description and parameter values
3. **Collect** a serialized representation like JSON
4. **Filter** based on parameters
5. **Format** into human-readable text
6. **View** matching events


**Note**: The application use the MsSqlServer `sink` to log in a database. Feel free to disable it if you want.
But that's here that we really understand how Serilog store the data.
If you keep it, you will need to have a database named `Serilog` in your localdb instance `(localdb)\V11.0`.
Feel free to update the connection string to do your tests.
