#!/usr/bin/env bash

set -euo pipefail

declare opts="-DdebugModels -Dproject -Dapis -Dmodels -DmodelTests=false -DmodelDocs=false $JAVA_OPTS"
declare curdir=$(cd $(dirname "${BASH_SOURCE}") && pwd)

# NOTE: This is sensitive to the location of this script.
declare clijar=${SWAGGER_CODEGEN_CLI_JAR:-$(cd $curdir && cd ../../../../../../../swagger-codegen-cli/target/ && echo $PWD)/swagger-codegen-cli.jar}

exec \java ${opts} -jar ${clijar} generate \
    -i serializable-model-spec.json -l csharp \
    --additional-properties targetFramework=v4.5 \
    -o serializable-model --additional-properties serializableModel=true;
