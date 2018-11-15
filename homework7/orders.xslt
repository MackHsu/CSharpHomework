<?xml version="1.0"?>
<xsl:stylesheet xmlns:xsl="http://www.w3.org/1999/XSL/Transform" version="1.0">
	<xsl:template match="/ArrayOfOrder">
		<html>
			<head>
				<title>订单列表</title>
			</head>
			<body>
				<table border="1" cellspacing="0">
					<tr>
						<th>订单号</th>
						<th>商品名</th>
						<th>客户名</th>
						<th>客户手机号码</th>
						<th>金额</th>
					</tr>
					<xsl:for-each select="Order">
						<tr>
							<td><xsl:value-of select="ID" /></td>
							<td><xsl:value-of select="ProductName" /></td>
							<td><xsl:value-of select="ClientName" /></td>
							<td><xsl:value-of select="ClientPhone" /></td>
							<td><xsl:value-of select="Money" /></td>
						</tr>
					</xsl:for-each>
				</table>
			</body>
		</html>
	</xsl:template>
</xsl:stylesheet>