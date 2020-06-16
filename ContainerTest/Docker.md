# Running ContainerTest in Docker

1) View and modify the ```Dockerfile``` as appropriate.

2) Execute the Docker build process:
```
$ docker build -t containertest -f Dockerfile .
```

3) Verify the image exists:
```
$ docker images
REPOSITORY                              TAG                 IMAGE ID            CREATED             SIZE
containertest                           latest              047e29f37f9c        2 seconds ago       328MB
mcr.microsoft.com/dotnet/core/sdk       3.1                 abbb476b7b81        11 days ago         737MB
mcr.microsoft.com/dotnet/core/runtime   3.1                 4b555235dfc0        11 days ago         327MB
```

4) Execute the container:
```
$ docker run containertest
```

5) Execute the container while replacing the ```test.txt``` file.  Note: use explicit paths.
```
$ docker run -v test.txt:/[path]/test.txt containertest
```

6) Get the container name:
```
$ docker ps
CONTAINER ID        IMAGE               COMMAND                  CREATED              STATUS
3627b4e812fd        ContainerTest       "dotnet ContainerT..."   About a minute ago   Up About a minute
```

7) Kill a running container:
```
$ docker kill [CONTAINER ID]
```

8) Delete a container image:
```
$ docker rmi [IMAGE ID] -f
```
