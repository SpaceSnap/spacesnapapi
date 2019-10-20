import * as functions from 'firebase-functions';

// // Start writing Firebase Functions
// // https://firebase.google.com/docs/functions/typescript
//
export const helloWorld = functions.https.onRequest((request, response) => {
 response.send("Hello from Firebase!");
});

export const searchStrings = functions.https.onRequest((request, response)=>{
    let list: string[] = ["machine", "rover", "technology", "space"];
    response.send(list);
});

