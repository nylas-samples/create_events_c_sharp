# create_events_c_sharp

This sample will show you to easily create events using the Events Endpoint API.

## Setup

```bash
$ mkdir create_events && cd create_events

$ dotnet new console
```

### System dependencies

- RestSharp
- DotNetEnv

### Gather environment variables

You'll need the following values:

```text
V3_API_KEY = ""
GRANT_ID = ""
CALENDAR_ID = ""
```

Add the above values to a new `.env` file:

```bash
$ touch .env # Then add your env variables
```

# Compilation

To compile the comment we need to use this `dotnet` command:

```bash
$ dotnet run --project create_events.csproj
```

## Usage

Run the app:

```bash
$ ./bin/Debug/net6.0/create_events
```

When you run it, it will display the newly created event and wait for a keystoke to end


## Learn more

Visit our [Nylas Calendar API documentation](https://developer.nylas.com/docs/connectivity/calendar/) to learn more.
