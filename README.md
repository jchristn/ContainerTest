# ContainerTest

Test project to build and run a Docker container while overriding local files within the container itself.

The ```Dockerfile``` is in the project directory.

1) Execute the Docker build process:
```
$ docker build -t containertest -f Dockerfile .
```

2) Verify the image exists:
```
$ docker images
REPOSITORY                              TAG                 IMAGE ID            CREATED             SIZE
containertest                           latest              047e29f37f9c        2 seconds ago       328MB
mcr.microsoft.com/dotnet/core/sdk       3.1                 abbb476b7b81        11 days ago         737MB
mcr.microsoft.com/dotnet/core/runtime   3.1                 4b555235dfc0        11 days ago         327MB
```

3) Execute the container:
```
$ docker run containertest
```

4) Execute the container while replacing the ```test.txt``` file.  Note: use explicit paths.  The first parameter after ```-v``` is the filename on the local filesystem, outside of the container image.  The second parameter is the path as it will be used in the app.  In this case, the app directory within the container image is ```/app/```.
```
$ docker run -v /[PathOnLocalFilesystem]/[Filename]:/app/test.txt containertest
```

5) Get the container name:
```
$ docker ps
CONTAINER ID        IMAGE               COMMAND                  CREATED              STATUS
3627b4e812fd        ContainerTest       "dotnet ContainerT..."   About a minute ago   Up About a minute
```

6) Kill a running container:
```
$ docker kill [CONTAINER ID]
```

7) Delete a container image:
```
$ docker rmi [IMAGE ID] -f
```
