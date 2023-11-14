export function instanceValue(instanceObject) {
    instanceObject.invokeMethodAsync("GetValueFromInstance")
          .then(result => { alert("Message from Method: " + result) })
}