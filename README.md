## Data Export
1. Export the Google Sheet as a Tab Separated Value file (.tsv)
2. Replace the `data` variable by your tsv content and execute:
```js
const data = `<YOUR TSV>`;
console.log(data.split('\n').map((ln) => {
	let cols = ln.split('\t')
	return `new string[] { "${cols[0]}", "${cols[1]}", "${cols[2]}", "${cols[3]}", "${cols[4]}", "${cols[5]}", "${cols[6]}" }`;
}).join(',\n'));
```