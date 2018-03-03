Start the presentation:

```shell
npm i
npm start
```

Commands used on bash/zsh to build and run an image with current directory name for tag:

```shell
docker build --tag ${PWD##*/} .
docker run --rm ${PWD##*/}
docker service create --name helloworld --secret message ${PWD##*/}
```