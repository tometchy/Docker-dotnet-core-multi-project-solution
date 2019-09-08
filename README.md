# Docker dotnet core multiple projects solution example

Example .NET Core solution with docker image build from project referencing other projects.
Dockerfile and other configuration written according to [SoftwareDeveloper.Blog post with Docker introduction](https://www.softwaredeveloper.blog/multi-project-dotnet-core-solution-in-docker-image).

Feel free to ask a question using issue, create a pull request with enhancements and star repository if you find it helpful :)

## Building image
From root directory (where solution file -  _Docker-dotnet-core-multi-project-solution.sln_ is stored) run _Docker build_ command:
``` bash
docker build -f Aspnetcoreapp/Dockerfile -t aspnetcoreapp .
```

## Running container
To run container for the first time, type _Docker run_ command:
``` bash
docker run -d -p 8080:80 --name my-running-application aspnetcoreapp
```

## Stopping container
To stop running container run _Docker stop_ command:
``` bash
docker stop my-running-application
```

## Starting stopped container
To start container which was stopped, type _Docker start_ command:
``` bash
docker start my-running-application
```
