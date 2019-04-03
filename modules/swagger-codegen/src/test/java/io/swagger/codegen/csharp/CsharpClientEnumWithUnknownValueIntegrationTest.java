package io.swagger.codegen.csharp;

import com.google.common.collect.ImmutableMap;
import io.swagger.codegen.AbstractIntegrationTest;
import io.swagger.codegen.CodegenConfig;
import io.swagger.codegen.CodegenConstants;
import io.swagger.codegen.languages.CSharpClientCodegen;
import io.swagger.codegen.testutils.IntegrationTestPathsConfig;
import org.testng.annotations.Test;

import java.io.IOException;
import java.util.HashMap;
import java.util.Map;

public class CsharpClientEnumWithUnknownValueIntegrationTest extends AbstractIntegrationTest {
    public CsharpClientEnumWithUnknownValueIntegrationTest() {
        generateSwaggerMetadata = false;

        ImmutableMap.Builder<String, String> builder = new ImmutableMap.Builder<String, String>();
        systemPropertyOverrides = builder
                .put(CodegenConstants.APIS, Boolean.FALSE.toString())
                .put(CodegenConstants.MODELS, Boolean.TRUE.toString())
                .put(CodegenConstants.API_DOCS, Boolean.FALSE.toString())
                .put(CodegenConstants.MODEL_DOCS, Boolean.FALSE.toString())
                .put(CodegenConstants.API_TESTS, Boolean.FALSE.toString())
                .put(CodegenConstants.MODEL_TESTS, Boolean.FALSE.toString())
                .put(CodegenConstants.SUPPORTING_FILES, Boolean.FALSE.toString())
                .build();
    }

    @Override
    protected IntegrationTestPathsConfig getIntegrationTestPathsConfig() {
        return new IntegrationTestPathsConfig("csharp/enums/enum-with-unknown-value");
    }

    @Override
    protected CodegenConfig getCodegenConfig() {
        return new CSharpClientCodegen();
    }

    @Override
    protected Map<String, String> configProperties() {
        Map<String, String> properties = new HashMap<>();
        properties.put(CodegenConstants.EXCLUDE_TESTS, Boolean.TRUE.toString());
        properties.put(CodegenConstants.CSHARP_ALLOW_UNKNOWN_ENUM_VALUE_IF_NULLABLE, Boolean.TRUE.toString());
        return properties;
    }

    // TODO: Remove this when super.generatesCorrectDirectoryStructure() is re-enabled.
    @Test(description = "Verify use of NullableStringEnumConverter if specified.")
    public void test() throws IOException {
        this.generatesCorrectDirectoryStructure();
    }
}
