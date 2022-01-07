#!/bin/bash

if [[ -z "$1" || -z "$2" ]]
then
    exit 1
fi

sam deploy --template-file ./pipeline.yml --s3-bucket $1 --s3-prefix send-me-an-image-pipeline --region sa-east-1 --capabilities CAPABILITY_NAMED_IAM --stack-name send-me-an-image-pipeline --parameter-overrides ParameterKey=ARTIFACTSBUCKET,ParameterValue="$2" --no-fail-on-empty-changeset